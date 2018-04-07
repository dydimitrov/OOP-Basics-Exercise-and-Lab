using System;
using System.Text;

public class Worker : Human
{
    private decimal weekSalary;
    private decimal worksHoursPerDay;
    private decimal salaryPerHour;
    private const decimal minSalary = 10m;
    private const decimal workingDays = 5m;

    public Worker(string firstName, string lastName, decimal weekSalary, decimal worksHoursPerDay) 
        : base(firstName,lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorksHoursPerDay = worksHoursPerDay;
        CalculatePaysPerHour();
    }
    public decimal WeekSalary
    {
        get { return weekSalary; }
        set
        {
            if (value<=minSalary)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            weekSalary = value;
        }
    }

    public decimal WorksHoursPerDay
    {
        get { return worksHoursPerDay; }
        set
        {
            if (value<1 || value>12)
            {
                throw new ArgumentException("Expected value mismatch!Argument: workHoursPerDay");
            }
            worksHoursPerDay = value;
        }
    }
    
    public decimal SalaryPerHour
    {
        get { return salaryPerHour; }
        set { salaryPerHour = value; }
    }


    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.AppendLine($"First Name: {this.FirstName}")
               .AppendLine($"Last Name: {this.LastName}")
               .AppendLine($"Week Salary: {this.WeekSalary:f2}")
               .AppendLine($"Hours per day: {this.WorksHoursPerDay:f2}")
               .AppendLine($"Salary per hour: {this.salaryPerHour:f2}");
        var result = builder.ToString().TrimEnd();

        return result;
    }
    internal void CalculatePaysPerHour()
    {
        var result = (this.WeekSalary / workingDays) / this.WorksHoursPerDay;
        this.SalaryPerHour = result;
    }
}