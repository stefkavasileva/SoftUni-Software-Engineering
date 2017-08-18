using System;

public class JobEventArgs : EventArgs
{
    public JobEventArgs(Job job)
    {
        this.Job = job;
    }

    public Job Job { get; }
}