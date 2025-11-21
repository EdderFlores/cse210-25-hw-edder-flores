using System;

class Program
{
    static void Main(string[] args)
    {
        string letter;
        Console.WriteLine("Hi there! Welcome to the grade program!");
        Console.Write("Please enter your grade percentage (0-100): ");
        float gradePercentage = float.Parse(Console.ReadLine());

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (letter != "F")
        {
            Console.WriteLine($"Your letter grade is: {letter}, you passed!");
        }
        else
        {
            Console.WriteLine($"Your letter grade is: {letter}, you failed. Try better next time!");
    }
    }
}