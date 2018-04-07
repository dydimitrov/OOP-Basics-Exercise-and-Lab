using System;
using System.Collections.Generic;
using System.Text;

public class Dog : Animal
{
    public Dog(string name, string favoriteFood) 
        : base(name,favoriteFood)
    {
    }

    public override string ExplainSelf()
    {
        return base.ExplainSelf() + Environment.NewLine + "MEEOW";
    }
}