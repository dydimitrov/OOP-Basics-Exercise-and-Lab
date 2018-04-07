using System;
using System.Text;

public class Tesla : ICar, IElectricCar
{
        private string model;
        private string color;
        private int battery;
    public Tesla(string model, string color, int battery)
    {
        this.Model = model;
        this.Color = color;
        this.Battery = battery;
    }

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }
    public string Color
    {
        get { return this.color; }
        set { this.color = value; }
    }
    public int Battery
    {
        get { return this.battery; }
        set { this.battery = value; }
    }

    public string Start()
    {
        return $"Engine start";
    }

    public string Stop()
    {
        return $"Breaaak!";
    }
    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine(GetInfo());
        builder.AppendLine(Start());
        builder.AppendLine(Stop());

        return builder.ToString().TrimEnd();
    }

    private string GetInfo()
    {
        var result = $"{this.Color} {this.GetType().Name} {this.Model} with {this.Battery} Batteries";
        return result;
    }
}