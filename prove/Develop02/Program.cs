using System;
using System.IO;

class Program
{
    static void DisplayMenu() 
    {
        Console.WriteLine("1. Add New Journal Entry");
        Console.WriteLine("2. Display Journal");
        Console.WriteLine("3. Save Journal");
        Console.WriteLine("4. Load Journal");
        Console.WriteLine("5. Quit");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        bool keepRunning = true;    
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (keepRunning) 
        {
            DisplayMenu();

            Console.Write("Enter 1, 2, 3, 4, or 5: ");
            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                DateTime theCurrentTime = DateTime.Now;

                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(theCurrentTime.ToString()); //exceeding core requirements
                Console.WriteLine("Prompt: " + prompt);
                Console.Write("Your entry: ");
                string journalEntry = Console.ReadLine();

                
                Entry newEntry = new Entry(theCurrentTime.ToString(), prompt, journalEntry);

                theJournal.AddEntry(newEntry);

                Console.WriteLine("Entry added!"); //Exceeding core requirements
            }
            else if (userChoice == "2")
            {
                theJournal.DisplayAll();
            }
            else if (userChoice == "3")
            {
                // Prompt user for the file name
                Console.Write("Enter the file name to save the journal: ");
                string fileName = Console.ReadLine();

                // Save journal entries to the user-specified file
                using (StreamWriter outputFile = new StreamWriter(fileName, false)) 
                {
                    foreach (var entry in theJournal._entries)
                    {
                        outputFile.WriteLine(entry.ToString());
                    }
                }
                Console.WriteLine("Journal saved!"); //Exceeding core requirements
            }
            else if (userChoice == "4")
            {
                // Prompt user for the file name
                Console.Write("Enter the file name to load the journal from: ");
                string filename = Console.ReadLine();

                // Check if the file exists before loading
                if (File.Exists(filename))
                {
                    // Clear current entries in the journal before loading new ones
                    theJournal._entries.Clear();
                     //modified stuff from the examples 
                    string[] lines = File.ReadAllLines(filename);

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split("~");
                        if (parts.Length == 3)
                        {
                            DateTime entryDate = DateTime.Parse(parts[0].Trim());//trim to make everything tidy
                            string promptText = parts[1].Trim(); 
                            string entryText = parts[2].Trim();

                            Entry entry = new Entry(entryDate.ToString(), promptText, entryText);
                            theJournal.AddEntry(entry);
                        }
                        else
                        {
                            Console.WriteLine("Invalid entry format in file."); 
                        }
                    }

                    Console.WriteLine("Journal loaded!");

                    // Display all loaded entries
                    Console.WriteLine("\nLoaded Journal Entries:");
                    theJournal.DisplayAll();
                }
                else
                {
                    Console.WriteLine("The file does not exist.");
                }
            }
            else if (userChoice == "5")
            {
                keepRunning = false;
            }
            else
            {
                Console.WriteLine("Sorry, that is not valid. Please try again.");
            }
        }
    }
}
