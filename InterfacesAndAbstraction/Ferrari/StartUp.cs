using System;
using System.Text;

namespace FerrariTask
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var driver = Console.ReadLine();

            Ferrari currentCar = new Ferrari(driver);
            Console.WriteLine(currentCar.ToString());

        }
    }
}
