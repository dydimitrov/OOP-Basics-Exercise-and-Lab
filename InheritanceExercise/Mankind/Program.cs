using System;

namespace Mankind
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var studentInput = Console.ReadLine().Split();
                var workerInput = Console.ReadLine().Split();

                Student student = new Student(studentInput[0], studentInput[1],studentInput[2]);
                Worker worker = new Worker(workerInput[0], 
                                           workerInput[1],
                                           decimal.Parse(workerInput[2]),
                                           int.Parse(workerInput[3]));

                Console.WriteLine(student + Environment.NewLine);
                Console.WriteLine(worker);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
