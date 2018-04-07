using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GoldenEditionBook: Book
{
    public override decimal Price
    {
        get
        {
            return base.Price;
        }
        set
        {
            base.Price = value;
        }
    }
    public GoldenEditionBook(string title, string author, decimal price)
        : base(title,author,price)
    {
        this.Price = price + (30 * price) / 100;
    }
}
