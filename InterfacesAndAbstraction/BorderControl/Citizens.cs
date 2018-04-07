using System;
using System.Collections.Generic;
using System.Text;

public class Citizen : IPerson
{
    private string name;
    private int age;
    private int id;
    public Citizen(string name , int age, int id)
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
        get { return age; }
        set { age = value; }
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
}
