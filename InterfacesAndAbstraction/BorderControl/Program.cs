using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var list = new List<IPerson>();

            while (line != "End")
            {
                var currentInfo = line.Split().ToList();
                if (currentInfo.Count == 3)
                {
                    var name = currentInfo[0];
                    var age = int.Parse(currentInfo[1]);
                    var id = currentInfo[2];
                    Citizen citizen = new Citizen(name, age, id);
                    list.Add(citizen);
                }
                else if (currentInfo.Count == 2)
                {
                    var model = currentInfo[0];
                    var id = currentInfo[1];
                    Robot robot = new Robot(model, id);
                    list.Add(robot);
                }
                line = Console.ReadLine();
            }

            var fakeIdEnd = Console.ReadLine();

            foreach (var person in list)
            {
                if (person.Id.EndsWith(fakeIdEnd))
                {
                    Console.WriteLine(person.Id);
                }
            }
        }
    }
}
