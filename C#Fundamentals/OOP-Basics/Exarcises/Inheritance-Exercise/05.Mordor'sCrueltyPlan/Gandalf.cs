using System;
using System.Text;

public class Gandalf : IMood
{
    public Gandalf(int mood = 0)
    {
        this.Mood = mood;
    }

    public int Mood { get; set; }

    private string MoodType()
    {
        if (this.Mood < -5)
        {
            return "Angry";
        }
        if (this.Mood >= -5 && this.Mood < 0)
        {
            return "Sad";
        }
        if (this.Mood >= 0 && this.Mood <= 15)
        {
            return "Happy";
        }

        return "JavaScript";
    }

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.Append(this.Mood)
            .Append(Environment.NewLine)
            .Append(this.MoodType());

        return builder.ToString();
    }
}