using System;
using System.Collections.Generic;
using System.Text;

public class Truck : IVehicle
{
    private double fuelAmount;
    private double fuelConsumption;
    private const double acAddOn = 1.6;
    public Truck(double fuelAmount, double fuelConsumption)
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
        if ((kilometers * this.FuelConsumption) > this.FuelAmount)
        {
            throw new ArgumentException("Truck needs refueling");
        }
        this.FuelAmount -= kilometers * this.FuelConsumption;
        Console.WriteLine($"Truck travelled {kilometers} km");
    }

    public void Refuel(double amount)
    {
        this.FuelAmount += amount * 0.95;
    }
}