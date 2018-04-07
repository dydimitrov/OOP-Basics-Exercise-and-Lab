using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Animal
{
    private string name;
    private int age;
    private string gender;
    public Animal(string name, int age, string gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid input!");
            }
            name = value;
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (string.IsNullOrEmpty(value.ToString()) || value<0)
            {
                throw new ArgumentException("Invalid input!");
            }
            age = value;
        }
    }

    public string Gender
    {
        get { return gender; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid input!");
            }
            gender = value;
        }
    }

    public virtual string GetInfo()
    {
        return $"{this.GetType().Name} + {Environment.NewLine}" +
               $" {this.Name} {this.Age} {this.Gender} ";
    }
}