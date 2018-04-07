using System;
using System.Collections.Generic;
using System.Text;

public class Circle : Shapes
{
    private double radius;

    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    public override double CalculateArea()
    {
        double result = 2 * Math.PI * this.Radius;
        return result;
    }

    public override double CalculatePerimeter()
    {
        double result = Math.PI * Math.Pow(this.Radius,2);
        return result;
    }
    public override string Draw()
    {
        return $"I am Circle.";
    }
}
