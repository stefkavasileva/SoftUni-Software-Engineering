using System.Collections.Generic;
using System.Text;

public class Route
{
    private IList<Room> rooms;
    private int length;
    private int difficulty;


    public Route(IList<Room> rooms)
    {
        this.rooms = rooms;
        this.Build();

    }

    private void Build()
    {
        this.difficulty = 0;
        for (int index = 0; index < this.rooms.Count; index++)
        {
            Room room = this.rooms[index];
            int roomDifficulty = room.getDifficulty();
            this.difficulty = this.difficulty + roomDifficulty;
        }

        this.length = 0;
        for (int index = 0; index < this.rooms.Count- 1; index++)
        {
            Room start = this.rooms[index];
            Room end = this.rooms[index + 1];
            Hallway hallway = start.getExit(end);
            int length = hallway.getLength();
            this.length = this.length + length;
        }
    }

    public IList<Room> getRooms()
    {
        return rooms;
    }

    public int getLength()
    {
        return length;
    }

    public int getDifficulty()
    {
        return difficulty;
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();

        builder.Append("Length: ");
        builder.Append(this.length);
        builder.Append("\t");
        builder.Append("Difficulty: ");
        builder.Append(this.difficulty);
        builder.Append("\t");

        Room room = this.rooms[0];
        builder.Append(room.getName());
        for (int index = 1; index < this.rooms.Count; index++)
        {
            builder.Append(" -> ");
            room = rooms[index];
            builder.Append(room.getName());

        }
        return builder.ToString();
    }

}

