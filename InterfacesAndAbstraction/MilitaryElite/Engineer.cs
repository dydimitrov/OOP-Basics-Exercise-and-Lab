using System;
using System.Collections.Generic;
using System.Text;

public class Engineer : Private, IEngineer,ISpecialisedSoldier
{
    private Corps corps;
    private HashSet<Repair> setOfRepairs;
    public Engineer() : base()
    {
        this.setOfRepairs = new HashSet<Repair>();
    }
    public Engineer(int id, string firstName, string lastName, double salary,Corps corps)
        : base(id, firstName, lastName, salary)
    {
        this.Corps = corps;
        this.setOfRepairs = new HashSet<Repair>();
    }
    public HashSet<Repair> SetOfRepairs
    {
        get { return this.setOfRepairs; }
        set { this.SetOfRepairs = value; }
    }

    public Corps Corps { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}")
            .AppendLine($"Corps: {this.Corps}")
            .AppendLine("Repairs:");
        foreach (var repair in this.SetOfRepairs)
        {
            sb.AppendLine("  "+repair.ToString());
        }

        return sb.ToString().Trim();
    }
}
