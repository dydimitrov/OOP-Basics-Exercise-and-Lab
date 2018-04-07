using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace FoodShortage
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var list = new List<IBuyer>();
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                var token = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (token.Length == 4)
                {
                    var name = token[0];
                    var age = int.Parse(token[1]);
                    var id = token[2];
                    var birthdate = DateTime.ParseExact(token[3],"dd/MM/yyyy", CultureInfo.InvariantCulture);
                    Citizen citizen = new Citizen(name, age, id, birthdate);
                    list.Add(citizen);
                }
                else if (token.Length == 3)
                {
                    var rebelName = token[0];
                    var rebelAge = int.Parse(token[1]);
                    var rebelGroup = token[2];
                    Rebel rebel = new Rebel(rebelName, rebelAge, rebelGroup);
                    list.Add(rebel);
                }
            }

            var nameOfPerson = Console.ReadLine();
            while (nameOfPerson != "End")
            {
                foreach (var person in list)
                {
                    if (person.Name == nameOfPerson)
                    {
                        person.BuyFood();
                    }
                }
                nameOfPerson = Console.ReadLine();
            }

            Console.WriteLine(list.Sum(l => l.Food));
        }
    }
}
