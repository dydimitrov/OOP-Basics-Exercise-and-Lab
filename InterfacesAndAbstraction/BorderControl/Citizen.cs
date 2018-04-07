using System;
using System.Collections.Generic;
using System.Text;

public class Citizen : IPerson
{
    private string id;
    private int age;
    private string name;
    public Citizen(string name, int age, string id)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
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

}