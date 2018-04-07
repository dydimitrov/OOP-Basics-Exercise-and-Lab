using System;
using System.Linq;

namespace VehiclesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carInfo = Console.ReadLine().Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries).ToArray();
            Car car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));

            var truckInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Truck truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

            var numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                var command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                try
                {
                    switch (command[0])
                    {
                        case "Drive":
                            if (command[1] == "Car")
                            {
                                car.Drive(double.Parse(command[2]));
                            }
                            else if (command[1] == "Truck")
                            {
                                truck.Drive(double.Parse(command[2]));
                            }
                            break;
                        case "Refuel":
                            if (command[1] == "Car")
                            {
                                car.Refuel(double.Parse(command[2]));
                            }
                            else if (command[1] == "Truck")
                            {
                                truck.Refuel(double.Parse(command[2]));
                            }
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    continue;
                }
            }
            Console.WriteLine($"Car: {car.FuelAmount:f2}");
            Console.WriteLine($"Truck: {truck.FuelAmount:f2}");
        }
    }
}
