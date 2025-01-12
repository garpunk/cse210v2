using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input your score to see your grade");
        string valueFromUser = Console.ReadLine();

        int grade = int.Parse(valueFromUser);

        string letter = "F";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"{letter}");

        if (grade >= 70)
        {
            Console.WriteLine("You Passed!");
        }
        else
        {
            Console.WriteLine("You Failed!");
        }
    }
}