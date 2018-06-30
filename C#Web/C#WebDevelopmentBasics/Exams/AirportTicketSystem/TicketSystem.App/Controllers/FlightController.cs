using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleMvc.Framework.Attributes.Methods;
using SimpleMvc.Framework.Interfaces;
using TicketSystem.App.Models.BindingModels;
using TicketSystem.App.Models.ViewModels;
using TicketSystem.Models;

namespace TicketSystem.App.Controllers
{
    public class FlightController : BaseController
    {
        [HttpGet]
        public IActionResult Catalog()
        {
            var flights = new List<Flight>();
            if (!this.User.IsAuthenticated)
            {
                flights = this.Context.Flights.Where(f => f.IsPublic).ToList();
            }
            else
            {
                using (this.Context)
                {
                    var isAdmin = this.Context.Users.First(u => u.Name == this.User.Name).IsAdmin;
                    if (!isAdmin)
                    {
                        flights = this.Context.Flights.Where(f => f.IsPublic).ToList();
                    }

                    flights = this.Context.Flights.ToList();
                }
            }

            var result = new StringBuilder();
            foreach (var flight in flights)
            {
                result.Append($@"<a href=""/flight/details?id={flight.Id}""class=""added-flight"">
                    <img src=""{flight.ImageUrl}"" alt=""flight-image"" class=""picture-added-flight"">
                    <h3>{flight.Destination}</h3>
                    <span>from {flight.Origin}</span><span>{flight.Date}</span>
                    </a>");
            }

            this.Model.Data["error"] = string.Empty;
            this.Model.Data["flights"] = result.ToString().Trim();

            return this.View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            this.Model.Data["error"] = string.Empty;
            if (!this.User.IsAuthenticated)
            {
                return RedirectToLogin();
            }

            if (!IsUserAdmin())
            {
                this.Model.Data["error"] = "Only admin can add flight";
                return RedirectToHome();
            }

            return this.View();
        }

        [HttpPost]
        public IActionResult Add(FlightAddBindingModel model)
        {
            if (!this.User.IsAuthenticated)
            {
                return RedirectToLogin();
            }

            var isAdmin = false;
            using (this.Context)
            {
                isAdmin = this.Context.Users.First(u => u.Name == this.User.Name).IsAdmin;

                if (!isAdmin)
                {
                    this.Model.Data["error"] = "Only admin can add flight";
                    return RedirectToHome();
                }

                if (!this.IsValidModel(model))
                {
                    this.Model.Data["error"] = GetErrorMessageFromInvalidProp(model);
                    return this.View();
                }

                var flightDb = new Flight
                {
                    Date = model.Date,
                    Destination = model.Destination,
                    ImageUrl = model.ImageUrl,
                    Origin = model.Origin,
                    Time = model.Time
                };

                this.Context.Flights.Add(flightDb);
                this.Context.SaveChanges();
            }

            return RedirectToHome();
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            if (!this.User.IsAuthenticated)
            {
                return RedirectToLogin();
            }

            Flight flight;
            var isAdmin = false;
            using (this.Context)
            {
                flight = this.Context.Flights.Find(id);
                isAdmin = this.Context.Users.First(u => u.Name == this.User.Name).IsAdmin;
            }

            if (flight is null)
            {
                return RedirectToHome();
            }

            var model = new FlightDetailsViewModel
            {
                Id = flight.Id,
                Origin = flight.Origin,
                Date = flight.Date,
                Time = flight.Time,
                Tickets = flight.Tickets,
                Diration = flight.Destination,
                ImageUrl = flight.ImageUrl
            };

            var editButton = isAdmin ?
                $@"<a href=""/flight/edit?id={model.Id}"" class=""edit-flight-detail""> <img src=""../Content/img/pencil.jpg"" style=""margin-top: 0px;"" alt=""image""></a>" :
                string.Empty;

            this.Model.Data["details"] = $@"
                    <section class=""ticket-area"">
                        <div class=""ticket-area-left"">
                        <img src = ""{model.ImageUrl}"" alt=""image"">
                        </div>
                            <div class=""ticket-area-right"">
                            <h3>{model.Diration}</h3>
                            <div>from {model.Origin}</div>
                            <div class=""data-and-time"">{model.Date} {model.Time} {editButton}</div>
                        </div>
                    </section>";

            var createSeat = isAdmin
                ? $@"<section class=""seat - info"">
                        <form action = ""/ticket/add?id={model.Id}"" class=""seat-form"">
                            <input type = ""text"" id=""Price"" name=""Price"" placeholder=""Price"">
                            <input type = ""text"" id=""Class"" name=""Class"" placeholder=""Type"">
                            <input type = ""number"" id=""TicketCount"" name=""TicketCount"" name=""quantity"" min=""1"" max=""999"" placeholder=""Tickets Counter"">
                            <input type = ""submit"" class=""create-seat"" value=""Create Seat"">
                        </form>
                    </section>"
                : string.Empty;

            var seats = new StringBuilder();
            foreach (var modelTicket in model.Tickets)
            {
                seats.AppendLine($@"<form action="""" class=""seat - form"">
                    <span>600$</span><span>Business</span>
                    <input type=""text"" placeholder = ""Add Number"" >
                    <input type=""submit"" class=""create-seat"" value=""Add to Cart"">");

                if (isAdmin) seats.AppendLine($@"<a href = ""/ticket/delete?id={modelTicket.Id}"" class=""delete"">X</a>");

                seats.Append("</form>");
            }

            this.Model.Data["createSeat"] = createSeat;
            this.Model.Data["seats"] = seats.ToString();

            return this.View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (!this.User.IsAuthenticated)
            {
                return RedirectToLogin();
            }

            Flight flight;
            var isAdmin = false;
            using (this.Context)
            {
                flight = this.Context.Flights.Find(id);
                isAdmin = this.Context.Users.First(u => u.Name == this.User.Name).IsAdmin;
            }

            if (!isAdmin)
            {
                this.Model.Data["error"] = "Only admin can add flight";
                return RedirectToHome();
            }

            if (flight is null)
            {
                return RedirectToHome();
            }

            var model = new FlightEditViewModel
            {
                Id = flight.Id,
                ImageUrl = flight.ImageUrl,
                Date = flight.Date,
                Origin = flight.Origin,
                Time = flight.Time,
                Destination = flight.Destination
            };

            this.Model.Data["Id"] = model.Id.ToString();
            this.Model.Data["Destination"] = model.Destination;
            this.Model.Data["Origin"] = model.Origin;
            this.Model.Data["Date"] = model.Date.ToString();
            this.Model.Data["Time"] = model.Time.ToString();
            this.Model.Data["ImageUrl"] = model.ImageUrl;
            return this.View();
        }

        [HttpPost]
        public IActionResult Edit(FlightEditViewModel model)
        {
            if (!this.User.IsAuthenticated) 
            {
                return RedirectToLogin();
            }

            var isAdmin = false;
            using (this.Context)
            {
                isAdmin = this.Context.Users.First(u => u.Name == this.User.Name).IsAdmin;

                if (!isAdmin)
                {
                    this.Model.Data["error"] = "Only admin can edit flight";
                    return RedirectToHome();
                }

                if (!this.IsValidModel(model))
                {
                    this.Model.Data["error"] = GetErrorMessageFromInvalidProp(model);
                    return this.View();
                }


                var flightDb = this.Context.Flights.Find(model.Id);
                flightDb.ImageUrl = model.ImageUrl;
                flightDb.Date = model.Date;
                flightDb.Destination = model.Destination;
                flightDb.Origin = model.Origin;
                flightDb.Time = model.Time;

                
                this.Context.SaveChanges();
            }

            return RedirectToHome();
        }


        private bool IsUserAdmin()
        {
            var isAdmin = false;
            using (this.Context)
            {
                isAdmin = this.Context.Users.First(u => u.Name == this.User.Name).IsAdmin;
            }

            return isAdmin;
        }
    }
}
