using System;
using System.Collections.Generic;
using System.Text;

public interface IVehicle
{
    double FuelAmount { get; set; }
    double FuelConsumption { get; set; }
    void Refuel(double amount);
    void Drive(double kilometers);
}