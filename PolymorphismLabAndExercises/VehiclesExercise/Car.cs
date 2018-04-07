using System;
using System.Collections.Generic;
using System.Text;

public class Car : IVehicle
{
    private double fuelAmount;
    private double fuelConsumption;
    private const double acAddOn = 0.9;
    public Car(double fuelAmount,double fuelConsumption)
    {
        this.FuelAmount = fuelAmount;
        this.FuelConsumption = fuelConsumption;
    }
    public double FuelAmount
    {
        get { return this.fuelAmount; }
        set { this.fuelAmount = value; }
    }
    public double FuelConsumption
    {
        get { return this.fuelConsumption; }
        set { this.fuelConsumption = value + acAddOn; }
    }

    public void Drive(double kilometers)
    {
        if ((kilometers*this.FuelConsumption)>this.FuelAmount)
        {
            throw new ArgumentException("Car needs refueling");
        }
        this.FuelAmount -= kilometers * this.FuelConsumption;
        Console.WriteLine($"Car travelled {kilometers} km");
    }

    public void Refuel(double amount)
    {
        this.FuelAmount += amount;
    }
}
