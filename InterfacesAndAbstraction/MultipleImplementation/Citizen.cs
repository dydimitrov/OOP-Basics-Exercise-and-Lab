using System;
using System.Collections.Generic;
using System.Text;

public class Citizen : IPerson,IBirthable,IIdentifiable
{
    private string name;
    private int age;
    private string birthDate;
    private string id;

    public Citizen(string name, int age, string id, string birthDate)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthdate = birthDate;
    }
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    public string Birthdate
    {
        get { return this.birthDate; }
        set { this.birthDate = value; }
    }

    public string Id
    {
        get { return this.id; }
        set { this.id = value; }
    }
}