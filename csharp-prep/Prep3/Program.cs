using System;

class Program
{
    static void Main(string[] args)
    {
         Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int userNumber = -1;

        

        while (number != userNumber)
        {
            Console.Write("What is your guess? ");
            userNumber = int.Parse(Console.ReadLine());

            if (number > userNumber)
            {
              Console.WriteLine("Higher");
           
            }

            else if (number < userNumber)
            {
                Console.WriteLine("Lower");
            
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}