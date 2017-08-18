using System;

public class Job
{
    private readonly IEmployee employee;
    private int hoursRequired;

    public Job(string name, int hoursRequired, IEmployee employee)
    {
        this.Name = name;
        this.hoursRequired = hoursRequired;
        this.employee = employee;
    }

    public event EventHandler<JobEventArgs> JobDone;

    public string Name { get; }

    public void Update()
    {
        this.hoursRequired -= this.employee.WorkHoursPerWeek;

        if (this.hoursRequired <= 0)
        {
            this.OnJobDone();
        }
    }

    public override string ToString()
    {
        return $"Job: {this.Name} Hours Remaining: {this.hoursRequired}";
    }

    protected virtual void OnJobDone()
    {
        Console.WriteLine($"Job {this.Name} done!");

        if (this.JobDone != null)
        {
            this.JobDone(this, new JobEventArgs(this));
        }
    }
}