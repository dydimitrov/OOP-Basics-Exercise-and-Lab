using System;
using System.Linq;

namespace CellPhonesManifacturing
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var urls = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (var number in numbers)
            {
                try
                {
                    SmartPhone currentPhone = new SmartPhone();
                    currentPhone.Number = number;
                    currentPhone.Call();
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    continue;
                }
            }
            if (urls.Count == 0)
            {
                Console.WriteLine("Browsing: !");
            }
            foreach (var url in urls)
            {
                try
                {
                    SmartPhone currentPhone = new SmartPhone();
                    currentPhone.Url = url;
                    currentPhone.Browse();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            }

        }
    }
}
