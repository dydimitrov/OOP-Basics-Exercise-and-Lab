using System;
using System.Collections.Generic;
using System.Text;

public class Tiger : Feline
{

    public const double IncreaseWeightRate = 1.00;
    
    public Tiger(string name, double weight, string breed,string livingRegion)
        : base(name, weight,livingRegion)
    {
        this.Breed = breed;
        this.FoodEaten = 0;
        InsertWhatCanBeEaten();
    }

    public override List<string> WhatCanEat { get; set; }
    public override string Name { get; set; }
    public override double Weight { get; set; }
    public override int FoodEaten { get; set; }
    public string Breed { get; set; }
    public override string LivingRegion { get; set; }

    public override void ProduceSound()
    {
        Console.WriteLine("ROAR!!!");
    }
    public override void Eat(int quantity)
    {
        this.Weight += quantity * IncreaseWeightRate;
        this.FoodEaten += quantity;
    }
    private void InsertWhatCanBeEaten()
    {
        this.WhatCanEat = new List<string>() { "Meat" };
    }
    public override string ToString()
    {
        return $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";

    }
}