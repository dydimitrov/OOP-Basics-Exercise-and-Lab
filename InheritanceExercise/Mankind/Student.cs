using System;
using System.Text;

public class Student : Human
{
    private string facultyNumber;

    public Student(string firstName, string lastName, string faculityNumber) 
        :base(firstName,lastName)
    {
        this.FacultyNumber = faculityNumber;
    }

    public string FacultyNumber
    {
        get
        {
            return this.facultyNumber;
        }

        set
        {
            if (value.Length < 5 || value.Length > 10 || !IsValidFacultyNumber(value))
            {
                throw new ArgumentException("Invalid faculty number!");
            }

            this.facultyNumber = value;
        }
    }

    private bool IsValidFacultyNumber(string value)
    {
        bool isValidFacultyNumber = true;
        foreach (char ch in value)
        {
            if (!char.IsLetterOrDigit(ch))
            {
                isValidFacultyNumber = false;
            }
        }

        return isValidFacultyNumber;
    }

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.AppendLine($"First Name: {this.FirstName}")
               .AppendLine($"Last Name: {this.LastName}")
               .AppendLine($"Faculty number: {this.FacultyNumber}");
        var result = builder.ToString().TrimEnd();

        return result; 
    }
}