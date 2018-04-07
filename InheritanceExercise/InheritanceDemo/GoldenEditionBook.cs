using System;
using System.Collections.Generic;
using System.Text;

public class GoldenEditionBook : Book
{
    private const decimal priceMultiplayer = 1.3m;
    public GoldenEditionBook(string author, string title, decimal price) 
        : base(author, title, price) { }

    public override decimal Price
    {
        get => base.Price;
        set => base.Price = value * priceMultiplayer;
    }
}
