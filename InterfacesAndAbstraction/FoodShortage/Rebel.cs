using System;
using System.Collections.Generic;
using System.Text;

public class Rebel : IBuyer
{
    private string name;
    private int age;
    private string group;
    private int food;
    private string rebelName;
    private int rebelAge;
    private string rebelGroup;

    public Rebel(string name, int age, string group)
    {
        this.Name = name;
        this.Age = age;
        this.Group = group;
        this.Food = 0;
    }
    public string Group
    {
        get { return group; }
        set { group = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Food
    {
        get { return food; }
        set { food = value; }
    }

    public void BuyFood()
    {
        this.food += 5;
    }
}