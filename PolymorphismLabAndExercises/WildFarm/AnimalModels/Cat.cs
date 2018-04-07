using System;
using System.Collections.Generic;
using System.Text;

public class Cat : Feline
{
    public const double IncreaseWeightRate = 0.30;
    
    
    public Cat(string name, double weight,string livingRegion, string breed) 
        : base(name, weight,livingRegion)
    {
        this.FoodEaten = 0;
        this.Breed = breed;
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
        Console.WriteLine("Meow");
    }
    public override void Eat(int quantity)
    {
        this.Weight += quantity * IncreaseWeightRate;
        this.FoodEaten += quantity;
    }
    private void InsertWhatCanBeEaten()
    {
        this.WhatCanEat = new List<string>() { "Vegetable", "Meat" };
    }
    public override string ToString()
    {
        return $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";

    }
}
