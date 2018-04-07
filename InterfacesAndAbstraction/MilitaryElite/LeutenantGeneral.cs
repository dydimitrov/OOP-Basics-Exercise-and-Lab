using System;
using System.Collections.Generic;
using System.Text;

public class LeutenantGeneral : Private, ILeutenantGeneral
{
    private List<Private> setOfSoldiers;
    public LeutenantGeneral():base()
    {
        this.setOfSoldiers = new List<Private>();
    }
    public LeutenantGeneral(int id,string firstName,string lastName,double salary)
        :base(id,firstName,lastName,salary)
    {
        this.setOfSoldiers = new List<Private>();
    }
    public List<Private> SetOfSoldiers
    {
        get { return this.setOfSoldiers; }
        set { this.setOfSoldiers = value; }
    }
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}")
            .AppendLine("Privates:");
        foreach (var p in this.SetOfSoldiers)
        {
            sb.AppendLine(p.ToString());
        }

        return sb.ToString().Trim();
    }
}
