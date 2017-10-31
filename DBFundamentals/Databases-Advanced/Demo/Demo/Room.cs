using System.Collections.Generic;
using System.Text;

public class Room
{
    private string name;
    private int difficulty;
    private IList<Room> entrances = new List<Room>();
    private IList<Room> exits = new List<Room>();

    public Room(string name, int difficulty)
    {
        this.Name = name;
        this.Difficulty = difficulty;
    }

    public string Name
    {
        get => this.name;
        protected set => value = this.name;
    }

    public int Difficulty
    {
        get => this.difficulty;
        protected set => value = this.difficulty;
    }


    public IList<Room> Entrances => this.entrances;

    public IList<Hallway> getEntrances()
    {
        return entrances;
    }

    public void AddEntrance(Room entrance)
    {
        if (!this.entrances.Contains(entrance))
        {
            this.entrances.Add(entrance);
            entrance.setEnd(this);
        }

    }

    public Hallway getExit(Room exit)
    {
        for (int index = 0; index < this.exits.Count; index++)
        {
            Hallway hallway = this.exits[index];
            if (hallway.getEnd() == exit)
            {
                return hallway;
            }

        }
        return null;

    }



    public IList<Hallway> getExits()
    {
        return exits;
    }

    public void addExit(Hallway exit)
    {
        if (this.exits.Contains(exit)) return;
        this.exits.Add(exit);
        exit.setStart(this);
    }



    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append(this.name);
        builder.Append("\t");
        builder.Append(this.difficulty);
        for (int index = 0; index < exits.Count; index++)
        {
            Hallway hallway = exits[index];
            builder.Append("\t");
            builder.Append(hallway);
        }


        return builder.ToString();

    }

}

