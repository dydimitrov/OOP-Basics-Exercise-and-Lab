using System;
using System.Collections.Generic;
using System.Text;

public abstract class Bird : Animal
{
    protected Bird(string name, double weight,double wingSize)
        :base(name,weight)
    {
        WingSize = wingSize;
    }

    public abstract double WingSize { get; set; }
    public override string ToString()
    {
        return $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
    }
}
