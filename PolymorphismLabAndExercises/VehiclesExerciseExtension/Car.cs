﻿using System;
using System.Collections.Generic;
using System.Text;

public class Car : IVehicle
{
    private double fuelAmount;
    private double fuelConsumption;
    private double tankCapacity;
    private const double acAddOn = 0.90;
    public Car(double fuelAmount,double fuelConsumption, double tankCapacity)
    {
        if (fuelAmount > tankCapacity)
        {
            this.FuelAmount = 0;
        }
        else
        {
            this.FuelAmount = fuelAmount;
        }
        this.FuelConsumption = fuelConsumption;
        this.TankCapacity = tankCapacity;
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

    public double TankCapacity
    {
        get { return this.tankCapacity; }
        set { this.tankCapacity = value; }
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
        if (amount <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }
        if (amount>(this.TankCapacity - this.FuelAmount))
        {
            throw new ArgumentException($"Cannot fit {amount} fuel in the tank");
        }
        this.FuelAmount += amount;
    }
}
