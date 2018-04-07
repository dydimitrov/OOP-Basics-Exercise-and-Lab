using System;
using System.Collections.Generic;
using System.Text;

public class Hen : Bird
{
    public const double IncreaseWeightRate = 0.35;
    
    public Hen(string name, double weight, double wingSize)
        : base(name, weight, wingSize)
    {
        this.Name = name;
        this.Weight = weight;
        this.FoodEaten = 0;
        this.WingSize = wingSize;
        InsertWhatCanBeEaten();
    }
    public override List<string> WhatCanEat { get; set; }
    public override string Name { get; set; }
    public override double Weight { get; set; }
    public override int FoodEaten { get; set; }
    public override double WingSize { get; set; }
    public override void ProduceSound()
    {
        Console.WriteLine("Cluck");
    }

    public override void Eat(int quantity)
    {
        this.Weight += quantity * IncreaseWeightRate;
        this.FoodEaten += quantity;
    }
    private void InsertWhatCanBeEaten()
    {
        this.WhatCanEat = new List<string>() {"Vegetable","Meat","Fruit" };
    }
    public override string ToString()
    {
        return base.ToString(); 
    }
}
