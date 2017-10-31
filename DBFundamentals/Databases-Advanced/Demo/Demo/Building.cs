using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Building
{
    private IList<Hallway> hallways = new List<Hallway>();
    private IList<Room> rooms = new List<Room>();
    private IList<Route> routs = new List<Route>();

    private Room entrance;
    private Room exit;

    public Building(string dataFile)
    {
        //Path file = Paths.get(dataFile);
        //List<string> data = FileWorker.readFile(file);
        List<string> data = File.ReadAllLines(dataFile).ToList();
        build(data);

        List<Room> route = new List<Room>();
        route.Add(this.entrance);
        this.findRoute(route);
    }


    private void build(List<string> data)
    {
        for (int index = 0; index < data.Count; index++)
        {
            String line = data[index];
            String[] lineArray = line.Split();
            String name = lineArray[0];
            int difficulty = int.Parse(lineArray[lineArray.Length - 1]);
            Room room = new Room(name, difficulty);
            this.rooms.Add(room);

        }

        for (int index = 0; index < data.Count; index++)
        {
            string line = data[index];
            string[] lineArray = line.Split();
            string start = lineArray[0];
            Room startRoom = findRoom(start);

            for (int index2 = 2; index2 < lineArray.Length; index2++)
            {
                string hallwayString = lineArray[index2];
                string[] hallwayArray = hallwayString.Split('-');
                string end = hallwayArray[1];
                Room endRoom = findRoom(end);
                int length = int.Parse(hallwayArray[0]);
                Hallway hallway = new Hallway(length);
                hallway.setStart(startRoom);
                hallway.setEnd(endRoom);
                this.hallways.Add(hallway);

            }
        }

        for (int index = 0; index < this.rooms.Count; index++)
        {
            Room room = this.rooms[index];
            if (room.getEntrances().Count == 0)
            {
                this.entrance = room;
                continue;
            }
            if (room.getExits().Count() == 0)
            {
                this.exit = room;
                continue;
            }
        }
    }

    public Room findRoom(String name)
    {
        for (int index = 0; index < this.rooms.Count; index++)
        {
            Room room = this.rooms[index];
            if (name.Equals(room.getName()))
            {
                return room;
            }

        }
        return null;

    }

    private void findRoute(List<Room> route)
    {
        Room room = route[route.Count() - 1];
        if (room == this.exit)
        {
            List<Room> finalRoute = new List<Room>(route);
            Route exitRoute = new Route(finalRoute);
            this.routs.Add(exitRoute);
            return;

        }

        for (int index = 0; index < room.getExits().Count(); index++)
        {
            Hallway exitHallway = room.getExits()[index];
            Room exitRoom = exitHallway.getEnd();
            route.Add(exitRoom);
            this.findRoute(route);
            route.RemoveAt(route.Count - 1);
        }
    }

    public void print()
    {
        for (int index = 0; index < this.rooms.Count; index++)
        {
            Room room = this.rooms[index];
            Console.WriteLine(room);
        }
        Console.WriteLine();
        Console.WriteLine("start:\t");
        Console.WriteLine(entrance);
        Console.WriteLine("end:\t");
        Console.WriteLine(exit);
        Console.WriteLine();
        Console.WriteLine();

        for (int index = 0; index < this.routs.Count(); index++)
        {
            Route route = this.routs[index];
            Console.WriteLine(route);
        }
    }
}

