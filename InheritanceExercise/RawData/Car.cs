using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Car
{
    private string model;
    private Cargo cargo;
    private Engine engine;
    private Tire tire;

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public Cargo Cargo
    {
        get { return cargo; }
        set { cargo = value; }
    }

    public Engine Engine
    {
        get { return engine; }
        set { engine = value; }
    }

    public Tire Tire
    {
        get { return tire; }
        set { tire = value; }
    }

    public Car()
    {

    }
    public Car(string model, Cargo cargo, Engine engine, Tire tire)
    {
        this.Model = model;
        this.Cargo = cargo;
        this.Engine = engine;
        this.Tire = tire;
    }

}
