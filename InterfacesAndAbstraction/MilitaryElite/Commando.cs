using System;
using System.Collections.Generic;
using System.Text;
using MilitaryElite;

public class Commando : Private, ICommando,ISpecialisedSoldier
{
    private Corps corps;
    public Commando(int id,string firstName,string lastName,double salary, Corps corps)
        :base(id,firstName,lastName,salary)
    {

        this.Corps = corps;
        this.Missions = new List<Mission>();
    }
    public List<Mission> Missions { get; }

    public Corps Corps { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}")
            .AppendLine($"Corps: {this.Corps}")
            .AppendLine("Missions:");
        foreach (var mission in this.Missions)
        {
            sb.AppendLine(mission.ToString());
        }

        return sb.ToString().Trim();
    }
}
