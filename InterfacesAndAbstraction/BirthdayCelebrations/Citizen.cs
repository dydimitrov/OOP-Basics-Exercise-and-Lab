using System;

public class Citizen : IPerson,IBornable
{
    private string id;
    private int age;
    private string name;
    private DateTime birthDate;
    public Citizen(string name, int age, string id, DateTime birthDate)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.BirthDate = birthDate;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Age  
    {
        get { return this.age; }
        set { this.age = value; }
    }
    public string Id
    {
        get { return this.id; }
        set { this.id = value; }
    }
    public DateTime BirthDate
    {
        get { return this.birthDate; }
        set
        {
            this.birthDate = value;
        }
    }

}