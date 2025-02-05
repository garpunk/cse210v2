using System;


class Program
{
    static void Main(string[] args)
    {
      Person p1 = new Person();
      p1.SetName("Jerry");
      p1.SetAge(23);

      p1.Display();

      string theName = p1.GetName();
      Console.Write($"The person's name was: {theName}");

    }

    static void DisplayMovie(Movie aMovie)
    {
     Console.WriteLine($"{aMovie._title} - {aMovie._year}");
    }

   
}

