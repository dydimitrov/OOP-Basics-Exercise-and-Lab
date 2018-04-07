using System;
using System.Collections.Generic;
using System.Text;

public abstract class Shapes
{
    public abstract double CalculatePerimeter();
    public abstract double CalculateArea();
    public virtual string Draw()
    {
        return $"I am a shape of somethink.";
    }
}
