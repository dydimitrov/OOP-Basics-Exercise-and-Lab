using System;
using System.Collections.Generic;
using System.Text;

public class Spy : ISoldier, ISpy
{
    private int id;
    private string firstName;
    private string lastName;
    private int codeNumber;
    
    public Spy(int id, string firstName, string lastName, int codeNumber)
    {
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
        this.CodeNumber = codeNumber;
    }
    public int Id
    {
        get { return this.id; }
        set { this.id = value; }
    }
    public string FirstName
    {
        get { return this.firstName; }
        set { this.firstName = value; }
    }
    public string LastName
    {
        get { return this.lastName; }
        set { this.lastName = value; }
    }
    public int CodeNumber
    {
        get { return this.codeNumber; }
        set { this.codeNumber = value; }
    }
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id}")
            .AppendLine($"Code Number: {this.CodeNumber}");

        return sb.ToString().Trim();
    }
}
