using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Tire
{
    private double tire1Pressure;
    private double tire2Pressure;
    private double tire3Pressure;
    private double tire4Pressure;
    private int tire1Age;
    private int tire2Age;
    private int tire3Age;
    private int tire4Age;

    public double Tire1Pressure
    {
        get { return tire1Pressure; }
        set { tire1Pressure = value; }
    }
    
    public double Tire2Pressure
    {
        get { return tire2Pressure; }
        set { tire2Pressure = value; }
    }
    
    public double Tire3Pressure
    {
        get { return tire3Pressure; }
        set { tire3Pressure = value; }
    }
    
    public double Tire4Pressure
    {
        get { return tire4Pressure; }
        set { tire4Pressure = value; }
    }

    public int Tire1Age
    {
        get { return tire1Age; }
        set { tire1Age = value; }
    }
    
    public int Tire2Age
    {
        get { return tire2Age; }
        set { tire2Age = value; }
    }
    
    public int Tire3Age
    {
        get { return tire3Age; }
        set { tire3Age = value; }
    }
    
    public int Tire4Age
    {
        get { return tire4Age; }
        set { tire4Age = value; }
    }

    public Tire(double tire1Pressure, int tire1Age, double tire2Pressure, int tire2Age,
                double tire3Pressure, int tire3Age, double tire4Pressure, int tire4Age)
    {
        this.Tire1Pressure = tire1Pressure;
        this.Tire1Age = tire1Age;
        this.Tire2Pressure = tire2Pressure;
        this.Tire2Age = tire2Age;
        this.Tire3Pressure = tire3Pressure;
        this.Tire3Age = tire3Age;
        this.Tire4Pressure = tire4Pressure;
        this.Tire4Age = tire4Age;
    }
}
