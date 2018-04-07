using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace BirthdayCelebrations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var list = new List<IBornable>();

            while (line != "End")
            {
                var currentInfo = line.Split().ToList();
                switch (currentInfo[0])
                {
                    case "Citizen":
                        var name = currentInfo[1];
                        var age = int.Parse(currentInfo[2]);
                        var id = currentInfo[3];
                        DateTime birthdate = DateTime.ParseExact(currentInfo[4], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        Citizen citizen = new Citizen(name, age, id,birthdate);
                        list.Add(citizen);
                        break;
                    case "Pet":
                        var namePet = currentInfo[1];
                        DateTime birthdatePet = DateTime.ParseExact(currentInfo[2], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        Pet pet = new Pet(namePet, birthdatePet);
                        list.Add(pet);
                        break;
                    default:
                        break;
                }
                line = Console.ReadLine();
            }

            var year = int.Parse(Console.ReadLine());

            foreach (var person in list)
            {
                if (person.BirthDate.Year==year)
                {
                    Console.WriteLine(String.Format("{0:dd/MM/yyyy}", person.BirthDate));
                }
            }
        }
    }
}
