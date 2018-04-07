using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class SmartPhone : ICallable, IBrowseable
{
    private string number;
    private string url;

    public SmartPhone()
    {

    }
    public string Number
    {
        get { return this.number; }
        set
        {
            if (!IsDigitsOnly(value))
            {
                throw new ArgumentException("Invalid number!");
            }
            this.number = value;
        }
    }

    public string Url
    {
        get { return this.url; }
        set
        {
            bool containsNum = Regex.IsMatch(value, @"\d");
            if (containsNum)
            {
                throw new ArgumentException("Invalid URL!");
            }
            this.url = value;
        }
    }

    public void Browse()
    {
        Console.WriteLine($"Browsing: {this.Url}!");
    }

    public void Call()
    {
        Console.WriteLine($"Calling... {this.Number}");
    }
    internal bool IsDigitsOnly(string str)
    {
        foreach (char c in str)
        {
            if (c < '0' || c > '9')
                return false;
        }

        return true;
    }
}
