using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Xml.Serialization;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Stations.Data;
using Stations.DataProcessor.Dto;
using Stations.Models;
using Stations.Models.Enums;

namespace Stations.DataProcessor
{
    public static class Deserializer
    {
        private const string FailureMessage = "Invalid data format.";
        private const string SuccessMessage = "Record {0} successfully imported.";

        public static string ImportStations(StationsDbContext context, string jsonString)
        {
            var sb = new StringBuilder();

            var stationDtos = JsonConvert.DeserializeObject<StationDto[]>(jsonString);

            var validStations = new List<Station>();

            foreach (var stationDto in stationDtos)
            {
                if (!IsValid(stationDto) || validStations.Any(s => s.Name.Equals(stationDto.Name)))
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                if (string.IsNullOrWhiteSpace(stationDto.Town))
                {
                    stationDto.Town = stationDto.Name;
                }

                var station = Mapper.Map<Station>(stationDto);
                validStations.Add(station);
                sb.AppendLine(string.Format(SuccessMessage, station.Name));
            }

            context.Stations.AddRange(validStations);
            context.SaveChanges();
            return sb.ToString().Trim();
        }

        public static string ImportClasses(StationsDbContext context, string jsonString)
        {
            var sb = new StringBuilder();

            var seatingClassDtos = JsonConvert.DeserializeObject<SeatingClassDto[]>(jsonString);
            var validClasses = new List<SeatingClass>();

            foreach (var seatingClassDto in seatingClassDtos)
            {
                if (!IsValid(seatingClassDto))
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                if (validClasses.Any(c => c.Name.Equals(seatingClassDto.Name)) ||
                    validClasses.Any(c => c.Abbreviation.Equals(seatingClassDto.Abbreviation)))
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var validCLass = Mapper.Map<SeatingClass>(seatingClassDto);
                validClasses.Add(validCLass);
                sb.AppendLine(string.Format(SuccessMessage, validCLass.Name));
            }

            context.SeatingClasses.AddRange(validClasses);
            context.SaveChanges();

            return sb.ToString().Trim();
        }

        public static string ImportTrains(StationsDbContext context, string jsonString)
        {
            TrainDto[] trainsFromJson = JsonConvert.DeserializeObject<TrainDto[]>(jsonString);
            var sb = new StringBuilder();
           var resultTrains = new List<Train>();

            foreach (var trainDto in trainsFromJson)
            {
                if (!IsValid(trainDto))
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var trainAlreadyExists = resultTrains.Any(t => t.TrainNumber == trainDto.TrainNumber);
                if (trainAlreadyExists)
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var trainSeatsAreValid = trainDto.Seats.All(IsValid);
                if (!trainSeatsAreValid)
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var seatClassesAreValid = trainDto.Seats.All(s =>
                    context.SeatingClasses.Any(sc => sc.Name == s.Name && sc.Abbreviation == s.Abbreviation));
                if (!seatClassesAreValid)
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                if (trainDto.Type is null)
                {
                    trainDto.Type = "HighSpeed";
                }

                var type = Enum.Parse<TrainType>(trainDto.Type);

                var trainSeats = trainDto.Seats.Select(s => new TrainSeat
                {
                    SeatingClass =
                            context.SeatingClasses.SingleOrDefault(sc =>
                                sc.Name == s.Name && sc.Abbreviation == s.Abbreviation),
                    Quantity = s.Quantity.Value
                })
                .ToArray();

                var currentTrain = new Train
                {
                    TrainNumber = trainDto.TrainNumber,
                    Type = type,
                    TrainSeats = trainSeats
                };

                resultTrains.Add(currentTrain);
                sb.AppendLine(string.Format(SuccessMessage, currentTrain.TrainNumber));
            }

            context.Trains.AddRange(resultTrains);
            context.SaveChanges();

            return sb.ToString().Trim();
        }

        public static string ImportTrips(StationsDbContext context, string jsonString)
        {
            var tripsFromJson = JsonConvert.DeserializeObject<TripDto[]>(jsonString);
            var sb = new StringBuilder();
            var resultTrips = new List<Trip>();

            foreach (var tripDto in tripsFromJson)
            {
                if (!IsValid(tripDto))
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var train = context.Trains.SingleOrDefault(t => t.TrainNumber == tripDto.Train);
                var originStation = context.Stations.SingleOrDefault(s => s.Name == tripDto.OriginStation);
                var destinationStation = context.Stations.SingleOrDefault(s => s.Name == tripDto.DestinationStation);

                if (train == null || originStation == null || destinationStation == null)
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var departureTime = DateTime.ParseExact(tripDto.DepartureTime, "dd/MM/yyyy HH:mm",
                    CultureInfo.InvariantCulture);
                var arrivalTime = DateTime.ParseExact(tripDto.ArrivalTime, "dd/MM/yyyy HH:mm",
                    CultureInfo.InvariantCulture);

                if (departureTime > arrivalTime)
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var status = Enum.Parse<TripStatus>(tripDto.Status);

                TimeSpan? timeDifference = null;
                if (tripDto.TimeDifference != null)
                {
                    timeDifference =
                        TimeSpan.ParseExact(tripDto.TimeDifference, @"hh\:mm", CultureInfo.InvariantCulture);
                }

                var currentTrip = new Trip
                {
                    ArrivalTime = arrivalTime,
                    DepartureTime = departureTime,
                    Train = train,
                    Status = status,
                    OriginStation = originStation,
                    DestinationStation = destinationStation,
                    TimeDifference = timeDifference
                };

                resultTrips.Add(currentTrip);
                sb.AppendLine($"Trip from {currentTrip.OriginStation.Name} to {currentTrip.DestinationStation.Name} imported.");
            }

            context.Trips.AddRange(resultTrips);
            context.SaveChanges();

            return sb.ToString().Trim();
        }

        public static string ImportCards(StationsDbContext context, string xmlString)
        {
            var serializer = new XmlSerializer(typeof(CardDto[]), new XmlRootAttribute("Cards"));
            var cardsFromXml = (CardDto[])serializer.Deserialize(new StringReader(xmlString));
            var sb = new StringBuilder();
            var resultCards = new List<CustomerCard>();

            foreach (var cardDto in cardsFromXml)
            {
                if (!IsValid(cardDto))
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var type = Enum.Parse<CardType>(cardDto.CardType);

                var currentCard = new CustomerCard
                {
                    Name = cardDto.Name,
                    Age = cardDto.Age,
                    Type = type
                };

                resultCards.Add(currentCard);
                sb.AppendLine(string.Format(SuccessMessage, currentCard.Name));
            }

            context.Cards.AddRange(resultCards);
            context.SaveChanges();

            return sb.ToString().Trim();
        }

        public static string ImportTickets(StationsDbContext context, string xmlString)
        {
            var serializer = new XmlSerializer(typeof(TicketDto[]), new XmlRootAttribute("Tickets"));
            var ticketsFromXml = (TicketDto[])serializer.Deserialize(new StringReader(xmlString));
            var sb = new StringBuilder();
            var resultTickets = new List<Ticket>();

            foreach (var ticketDto in ticketsFromXml)
            {
                if (!IsValid(ticketDto))
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var departureTime =
                    DateTime.ParseExact(ticketDto.Trip.DepartureTime, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

                var trip = context.Trips
                    .Include(t => t.OriginStation)
                    .Include(t => t.DestinationStation)
                    .Include(t => t.Train)
                    .ThenInclude(tr => tr.TrainSeats)
                    .SingleOrDefault(t => t.OriginStation.Name == ticketDto.Trip.OriginStation &&
                                          t.DestinationStation.Name == ticketDto.Trip.DestinationStation &&
                                          t.DepartureTime == departureTime);

                if (trip == null)
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                CustomerCard card = null;
                if (ticketDto.Card != null)
                {
                    card = context.Cards.SingleOrDefault(c => c.Name == ticketDto.Card.Name);

                    if (card == null)
                    {
                        sb.AppendLine(FailureMessage);
                        continue;
                    }
                }

                var seatingClassAbbreviation = ticketDto.Seat.Substring(0, 2);
                var seatingClassNumber = int.Parse(ticketDto.Seat.Substring(2));

                var seatClassExistsInTrain =
                    trip.Train.TrainSeats.Any(ts => ts.SeatingClass.Abbreviation == seatingClassAbbreviation);

                if (seatClassExistsInTrain)
                {
                    var isSeatingNumberValid =
                         trip.Train
                        .TrainSeats
                        .Single(ts => ts.SeatingClass.Abbreviation == seatingClassAbbreviation)
                        .Quantity >= seatingClassNumber;

                    if (!isSeatingNumberValid)
                    {
                        sb.AppendLine(FailureMessage);
                        continue;
                    }
                }
                else
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var currentTicket = new Ticket
                {
                    Trip = trip,
                    CustomerCard = card,
                    Price = ticketDto.Price,
                    SeatingPlace = ticketDto.Seat
                };

                resultTickets.Add(currentTicket);
                sb.AppendLine($"Ticket from {trip.OriginStation.Name} to {trip.DestinationStation.Name} departing at {trip.DepartureTime.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture)} imported.");
            }

            context.Tickets.AddRange(resultTickets);
            context.SaveChanges();

            return sb.ToString().Trim();
        }

        private static bool IsValid(object obj)
        {
            var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(obj);
            var validationResult = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(obj, validationContext, validationResult, true);

            return isValid;
        }
    }
}