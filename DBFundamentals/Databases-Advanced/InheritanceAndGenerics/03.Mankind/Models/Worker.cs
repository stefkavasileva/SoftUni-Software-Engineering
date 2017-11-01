using System;
using System.Text;

public class Worker :Human
{
    private decimal workHoursPerDay;
    private decimal weekSalary;

    public Worker(string firstName, string lastName,decimal weekSalary,decimal workHoursPerDay) 
        : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public decimal WorkHoursPerDay
    {
        get => this.workHoursPerDay;
        protected set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException(string.Format(ErrorMessages.InvalidWorkingHours, nameof(this.workHoursPerDay)));
            }

            this.workHoursPerDay = value;
        }
    }

    public decimal WeekSalary
    {
        get => this.weekSalary;
        protected set
        {
            if (value < 10)
            {
                throw new ArgumentException(string.Format(ErrorMessages.InvalidWeekSalary, nameof(this.weekSalary)));
            }

            this.weekSalary = value;
        }
    }


    private decimal GetSalaryPerHour()
    {
        return this.WeekSalary / (5 * this.WorkHoursPerDay);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Week Salary: {this.WeekSalary:f2}");
        sb.AppendLine($"Hours per day: {this.WorkHoursPerDay:f2}");
        sb.AppendLine($"Salary per hour: {GetSalaryPerHour():f2}");

        return $"{base.ToString()}{Environment.NewLine}{sb.ToString().Trim()}";
    }
}

