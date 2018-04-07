using System;
using System.Collections.Generic;
using System.Linq;

namespace WildFarm
{
    public class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int countOfRows = 0;

            var listOfAnimals = new List<Animal>();
            var result = new List<Animal>();


            while (input != "End")
            {
                try
                {
                    var command = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                    if (countOfRows % 2 == 0)
                    {
                        switch (command[0])
                        {
                            case "Owl":
                                Owl owl = new Owl(command[1], double.Parse(command[2]), double.Parse(command[3]));
                                listOfAnimals.Add(owl);
                                break;
                            case "Hen":
                                Hen hen = new Hen(command[1], double.Parse(command[2]), double.Parse(command[3]));
                                listOfAnimals.Add(hen);
                                break;
                            case "Cat":
                                Cat cat = new Cat(command[1], double.Parse(command[2]), command[3], command[4]);
                                listOfAnimals.Add(cat);
                                break;
                            case "Tiger":
                                Tiger tiger = new Tiger(command[1], double.Parse(command[2]),command[4], command[3]);
                                listOfAnimals.Add(tiger);
                                break;
                            case "Mouse":
                                Mouse mouse = new Mouse(command[1], double.Parse(command[2]), command[3]);
                                listOfAnimals.Add(mouse);
                                break;
                            case "Dog":
                                Dog dog = new Dog(command[1], double.Parse(command[2]), command[3]);
                                listOfAnimals.Add(dog);
                                break;
                            default:
                                throw new ArgumentException("Invalid Animal!");
                        }
                    }
                    else
                    {
                        var currentAnimal = listOfAnimals[listOfAnimals.Count - 1];
                        currentAnimal.ProduceSound();
                        switch (command[0])
                        {
                            case "Fruit":
                                Fruit fruit = new Fruit(int.Parse(command[1]));
                                if (currentAnimal.WhatCanEat.Contains(fruit.GetType().Name))
                                {
                                    currentAnimal.Eat(fruit.Quantity);
                                    result.Add(currentAnimal);
                                }
                                else
                                {
                                    result.Add(currentAnimal);
                                    throw new ArgumentException($"{currentAnimal.GetType().Name} does not eat {fruit.GetType().Name}!");
                                }
                                break;
                            case "Meat":
                                Meat meat = new Meat(int.Parse(command[1]));
                                if (currentAnimal.WhatCanEat.Contains(meat.GetType().Name))
                                {
                                    currentAnimal.Eat(meat.Quantity);
                                    result.Add(currentAnimal);
                                }
                                else
                                {
                                    result.Add(currentAnimal);
                                    throw new ArgumentException($"{currentAnimal.GetType().Name} does not eat {meat.GetType().Name}!");
                                }
                                break;
                            case "Vegetable":
                                Vegetable vegetable = new Vegetable(int.Parse(command[1]));
                                if (currentAnimal.WhatCanEat.Contains((vegetable.GetType().Name).ToString()))
                                {
                                    currentAnimal.Eat(vegetable.Quantity);
                                    result.Add(currentAnimal);
                                }
                                else
                                {
                                    result.Add(currentAnimal);
                                    throw new ArgumentException($"{currentAnimal.GetType().Name} does not eat {vegetable.GetType().Name}!");
                                }
                                break;
                            default:
                                throw new ArgumentException("Invalid Food!");
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                input = Console.ReadLine();
                countOfRows++;
            }
            foreach (var animal in result)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
