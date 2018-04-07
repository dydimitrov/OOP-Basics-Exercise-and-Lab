using System;
using System.Collections.Generic;
using System.Text;

public abstract class Animal
{
    public Animal(string name, double weight)
    {
        this.Name = name;
        this.Weight = weight;
    }
    public virtual List<string> WhatCanEat { get; set; }
    public abstract string Name { get; set; }
    public abstract double Weight { get; set; }
    public abstract int FoodEaten { get; set; }
    public virtual void ProduceSound()
    {
        Console.WriteLine("Ask for Food");
    }
    public abstract void Eat(int quantity);
    public override string ToString()
    {
        return base.ToString();
    }
}
