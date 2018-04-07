using System;
using System.Collections.Generic;
using System.Text;

public class Rectangle : Shapes
{
    private double height;
    private double width;
    public Rectangle(double height, double width)
    {
        this.Height = height;
        this.Width = width;
    }
    public double Width
    {
        get { return width; }
        protected set { width = value; }
    }

    public double Height
    {
        get { return height; }
        protected set { height = value; }
    }

    public override double CalculateArea()
    {
        double result = 2 * this.Height + 2 * this.Width;
        return result;
    }

    public override double CalculatePerimeter()
    {
        double result =this.Height * this.Width;
        return result;
    }
    public override string Draw()
    {
        return $"I am Rectangle.";
    }
}