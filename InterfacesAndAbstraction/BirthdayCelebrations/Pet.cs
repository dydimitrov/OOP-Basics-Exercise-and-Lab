using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

public class Pet : IBornable
{
    private string name;
    private DateTime birthDate;
    public Pet(string name, DateTime birthDate)
    {
        this.Name = name;
        this.BirthDate = birthDate;
    }
    public DateTime BirthDate
    {
        get { return this.birthDate; }
        set
        {
            this.birthDate = value;
        }
    }
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

}