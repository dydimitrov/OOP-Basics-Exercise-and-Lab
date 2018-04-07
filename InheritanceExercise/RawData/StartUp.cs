using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    static void Main(string[] args)
    {
        int numberOfCars = int.Parse(Console.ReadLine());
        var listOfCars = new List<Car>();
        
        for (int i = 0; i < numberOfCars; i++)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string model = input[0];
            var currentEngine = new Engine(int.Parse(input[1]), int.Parse(input[2]));
            var currentCargo = new Cargo(double.Parse(input[3]), input[4]);
            var currentTire = new Tire(double.Parse(input[5]), int.Parse(input[6]),
                                       double.Parse(input[7]), int.Parse(input[8]),
                                       double.Parse(input[9]), int.Parse(input[10]),
                                       double.Parse(input[11]), int.Parse(input[12]))
            var currentCar = new Car
        }
    }
}
