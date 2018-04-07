using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cargo
{
    private double cargoWeight;
    private string cargoType;

    public double CargoWeight
    {
        get { return cargoWeight; }
        set { cargoWeight = value; }
    }

    public string CargoType
    {
        get { return cargoType; }
        set { cargoType = value; }
    }

    public Cargo(double cargoWeight, string cargoType)
    {
        this.CargoWeight = cargoWeight;
        this.CargoType = cargoType;
    }

}