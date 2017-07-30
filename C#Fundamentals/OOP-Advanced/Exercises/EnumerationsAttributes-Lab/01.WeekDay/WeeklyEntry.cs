using System;

public class WeeklyEntry : IComparable<WeeklyEntry>
{
    private WeekDay weekDay;

    public WeeklyEntry(string weekDay, string notes)
    {
        Enum.TryParse(weekDay, out this.weekDay);
        this.Notes = notes;
    }

    public WeekDay WeekDay => this.weekDay;
    public string Notes { get; protected set; }


    public int CompareTo(WeeklyEntry other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        var weekDayComparison = weekDay.CompareTo(other.weekDay);
        if (weekDayComparison != 0) return weekDayComparison;
        return string.Compare(Notes, other.Notes, StringComparison.Ordinal);
    }

    public override string ToString()
    {
        return $"{this.WeekDay} - {this.Notes}";
    }
}

