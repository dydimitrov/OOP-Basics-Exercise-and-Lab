using System;
using System.Collections.Generic;
using System.Text;

public class Ferrari : ICar
{
    private string driverName;
    private string model = "488-Spider";

    public Ferrari(string driverName)
    {
        this.DriverName = driverName;
    }
    public string Model
    {
        get { return model; }
    }

    public string DriverName
    {
        get { return driverName; }
        set { driverName = value; }
    }

    public string BreakPush()
    {
        return "Brakes!";
    }

    public string ThrotlePush()
    {
        return "Zadu6avam sA!";
    }
    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.Append(this.Model + "/");
        builder.Append(this.BreakPush() + "/");
        builder.Append(this.ThrotlePush() + "/");
        builder.Append(this.DriverName);
        return builder.ToString().TrimEnd();
    }
}