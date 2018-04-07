using System;
using System.Collections.Generic;
using System.Text;

public class Private : ISoldier,IPrivate
{
    private int id;
    private string firstName;
    private string lastName;
    private double salary;
    public Private():base()
    {

    }
    public Private(int id, string firstName, string lastName, double salary)
    {
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
        this.Salary = salary;
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
    public double Salary
    {
        get { return this.salary; }
        set { this.salary = value;}
    }
    public override string ToString()
    {
        return $"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}";
    }
}
