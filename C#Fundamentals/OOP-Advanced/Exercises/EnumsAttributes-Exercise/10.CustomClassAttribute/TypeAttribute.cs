using System;
using System.Collections.Generic;

[AttributeUsage(AttributeTargets.Class)]
public class CustomAttribute : Attribute
{
    private readonly string author;
    private readonly int revision;
    private readonly string description;
    private readonly IList<string> reviewers;

    public CustomAttribute(string author, int revision, string description, params string[] inputReviewers)
    {
        this.author = author;
        this.revision = revision;
        this.description = description;
        this.reviewers = new List<string>();

        foreach (string reviewer in inputReviewers)
        {
            this.reviewers.Add(reviewer);
        }
    }

    public string Print(string element)
    {
        switch (element)
        {
            case "Author":
                return $"Author: {this.author}";

            case "Revision":
                return $"Revision: {this.revision}";

            case "Description":
                return $"Class description: {this.description}";

            case "Reviewers":
                return $"Reviewers: {string.Join(", ", this.reviewers)}";
        }

        return string.Empty;
    }
}