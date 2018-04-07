using System;
using System.Text;

public class Dog : Animal,ISoundProducable
{
    public Dog(string name, int age, string gender)
        :base(name,age,gender)
    {

    }

    public void ProduceSound()
    {
        Console.WriteLine("Woof!");
    }
    public override string GetInfo()
    {
        StringBuilder builder = new StringBuilder();

        return base.GetInfo();
    }
}