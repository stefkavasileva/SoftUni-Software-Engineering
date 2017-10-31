using System;
using System.Text;

public class Hallway
{
    private int length;
    private Room start;
    private Room end;

    public Hallway(int length)
    {
        this.length = length;
    }

    public int getLength()
    {
        return length;
    }

    public void setLength(int length)
    {
        this.length = length;
    }


    public Room getStart()
    {
        return start;
    }

    public void setStart(Room start)
    {
        if (this.start == start) return;
        this.start = start;
        start.addExit(this);
    }

    public Room getEnd()
    {
        return end;
    }

    public void setEnd(Room end)
    {
        if (this.end == end) return;
        this.end = end;
        end.addEntrance(this);
    }

   
    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append(this.length);
        builder.Append('-');
        if (end != null)
        {
            builder.Append(end.getName());
        }
        else
        {
            builder.Append('#');
        }

        return builder.ToString();

    }
}

