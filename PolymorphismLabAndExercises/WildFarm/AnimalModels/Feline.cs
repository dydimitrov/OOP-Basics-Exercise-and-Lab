using System;
using System.Collections.Generic;
using System.Text;

public abstract class Feline : Mammal
{
    public Feline(string name, double weight,string livingRegion) 
        : base(name, weight,livingRegion)
    {
    }
    public override string ToString()
    {
        return base.ToString();
    }
}
