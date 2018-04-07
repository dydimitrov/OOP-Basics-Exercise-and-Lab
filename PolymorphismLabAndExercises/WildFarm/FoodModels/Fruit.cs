using System;
using System.Collections.Generic;
using System.Text;

public class Fruit : Food
{
    public override int Quantity { get; set; }
    public Fruit(int quantity)
    {
        this.Quantity = quantity;
    }
}