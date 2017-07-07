using System;
using System.Text;

public class Worker : Human
{
    private double weekSalary;
    private double workHoursPerDay;

    public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
        : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public double WeekSalary
    {
        get => this.weekSalary;
        private set
        {
            if (value < 10)
            {
                throw new ArgumentException($"Expected value mismatch! Argument: {nameof(weekSalary)}");
            }

            this.weekSalary = value;
        }
    }

    public double WorkHoursPerDay
    {
        get => this.workHoursPerDay;
        private set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException($"Expected value mismatch! Argument: {nameof(workHoursPerDay)}");
            }

            this.workHoursPerDay = value;
        }
    }

    private double GetSalaryPerHour()
    {
        return this.WeekSalary / (WorkHoursPerDay * 5.0);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"First Name: {this.FirstName}");
        sb.AppendLine($"Last Name: {this.LastName}");
        sb.AppendLine($"Week Salary: {this.WeekSalary:f2}");
        sb.AppendLine($"Hours per day: {this.WorkHoursPerDay:f2}");
        sb.AppendLine($"Salary per hour: {this.GetSalaryPerHour():f2}");

        return sb.ToString();
    }
}
