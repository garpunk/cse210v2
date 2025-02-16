using System;
using System.Collections.Generic;

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the scripture memorization program!");

        // Create the scripture library and pick a random scripture
        ScriptureLibrary scriptureLibrary = new ScriptureLibrary();
        Scripture scripture = scriptureLibrary.GetRandomScripture();
        Reference reference = scripture.GetReference(); // Make sure Scripture has a GetReference() method

        bool running = true;

        while (running && !scripture.IsAllHidden())  // The loop stops when all words are hidden
        {
            Console.Clear();
            Console.WriteLine(reference.GetDisplayContent()); // Display reference
            Console.WriteLine(scripture.GetDisplayContent()); // Display scripture

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
            {
                running = false;
            }
            else
            {
                scripture.HideRandomWords(2); // Hide 2 words at a time
            }
        }

        // This runs after the loop exits, when all words are hidden
        if (scripture.IsAllHidden())
        {
            Console.Clear();
            Console.WriteLine(reference.GetDisplayContent());
            Console.WriteLine(scripture.GetDisplayContent());
            Console.WriteLine("\nAll words are hidden! Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
