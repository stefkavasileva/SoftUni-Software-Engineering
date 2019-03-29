using System.Collections.Generic;

public class Exercise
{
    public Exercise(string topic, string courseName, string judgeContestLink, List<string> problems)
    {
        this.Topic = topic;
        this.CourseName = courseName;
        this.JudgeContestLink = judgeContestLink;
        this.Proglems = problems;
    }

    public string Topic { get; set; }

    public string CourseName { get; set; }

    public string JudgeContestLink { get; set; }

    public List<string> Proglems { get; set; }
}

