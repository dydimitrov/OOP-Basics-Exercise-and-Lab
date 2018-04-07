using System;
using System.Collections.Generic;
using System.Text;

public class Vegetable : Food
{
    public override int Quantity { get; set; }
    public Vegetable(int quantity)
    {
        this.Quantity = quantity;
    }

}
