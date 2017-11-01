using System.Collections.Generic;
using System.Text;

public class Route
{
    private IList<Room> rooms;
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
    }

    public IList<Room> getRooms()
    {
        return rooms;
    }

    public int getDifficulty()
    {
        return difficulty;
    }

    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();

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

    //public Room getStart()
    //{
    //    return start;
    //}

    //public void setStart(Room start)
    //{
    //    if (this.start == start) return;
    //    this.start = start;
    //    //start.addExit(this);
    //}

    //public Room getEnd()
    //{
    //    return end;
    //}

    //public void setEnd(Room end)
    //{
    //    if (this.end == end) return;
    //    this.end = end;
    //    //end.addEntrance(this);
    //}
}

