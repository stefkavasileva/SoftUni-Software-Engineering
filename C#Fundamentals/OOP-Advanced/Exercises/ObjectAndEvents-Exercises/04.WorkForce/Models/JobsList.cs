using System.Collections.Generic;

public class JobsList : List<Job>
{
    public void OnJobDone(object source, JobEventArgs args)
    {
        args.Job.JobDone -= this.OnJobDone;
        this.Remove(args.Job);
    }
}