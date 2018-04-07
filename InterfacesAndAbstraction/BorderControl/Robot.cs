using System;
using System.Collections.Generic;
using System.Text;

public class Robot : IPerson
{
    private string id;
    private string model;

    public Robot(string model, string id)
    {
        this.Model = model;
        this.Id = id;
    }
    public string Id
    {
        get { return this.id; }
        set { this.id = value; }
    }
    public string Model
    {
        get { return model; }
        set { model = value; }
    }

}