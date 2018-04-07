using System;
using System.Collections.Generic;
using System.Text;

public class Mouse : Mammal
{
    public const double IncreaseWeightRate = 0.10;
    
    public Mouse(string name, double weight, string livingRegion)
        :base(name,weight,livingRegion)
    {
        this.Name = name;
        this.Weight = weight;
        this.FoodEaten = 0;
        this.LivingRegion = livingRegion;
        InsertWhatCanBeEaten();
    }
    public override List<string> WhatCanEat { get; set; }
    public override string LivingRegion { get; set; }
    public override string Name { get; set; }
    public override double Weight { get; set; }
    public override int FoodEaten { get; set; }
    public override void ProduceSound()
    {
        Console.WriteLine("Squeak");
    }
    public override void Eat(int quantity)
    {
        this.Weight += quantity * IncreaseWeightRate;
        this.FoodEaten += quantity;
    }
    private void InsertWhatCanBeEaten()
    {
        this.WhatCanEat = new List<string>() { "Vegetable", "Fruit" };
    }
    public override string ToString()
    {
        return base.ToString() + $"{this.FoodEaten}]";
    }
}
