using System;
using System.Collections.Generic;
using System.Text;

public class Robot : IPerson
{
    private string model;
    private int id;
    public Robot(string model, int id)
    {
        this.Model = model;
        this.Id = id;
    }
    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public int Id
    {
        get { return id; }
        set { Id = value; }
    }
}
