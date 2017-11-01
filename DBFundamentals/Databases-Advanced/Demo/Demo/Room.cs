using System.Collections.Generic;
using System.Text;

public class Room
{
    private string name;
    private int difficulty;
  
    private List<Room> entrances = new List<Room>();
    private List<Room> exits = new List<Room>();

    public Room(string name, int difficulty)
    {
        this.name = name;
        this.difficulty = difficulty;
    }

    public string getName()
    {
        return name;
    }

    public void setName(string name)
    {
        this.name = name;
    }

    public int getDifficulty()
    {
        return difficulty;
    }

    public List<Room> getEntrances()
    {
        return entrances;
    }

    public Room getExit(Room exit)
    {
        for (int index = 0; index < this.exits.Count; index++)
        {
            Room hallway = this.exits[index];
            if (hallway.getName() == exit.getName())
            {
                return hallway;
            }

        }
        return null;

    }

    public void addEntrance(Room entrance)
    {
        if (this.entrances.Contains(entrance)) return;
        this.entrances.Add(entrance);
    }

    public List<Room> getExits()
    {
        return exits;
    }

    public void addExit(Room exit)
    {
        if (this.exits.Contains(exit)) return;
        this.exits.Add(exit);
    }

    public void setDifficulty(int difficulty)
    {
        this.difficulty = difficulty;
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append(this.name);
        builder.Append("\t");
        builder.Append(this.difficulty);
        for (int index = 0; index < exits.Count; index++)
        {
            Room hallway = exits[index];
            builder.Append("\t");
            builder.Append(hallway);
        }


        return builder.ToString();

    }

}

