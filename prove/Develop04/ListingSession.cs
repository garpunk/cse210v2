using System;
using System.Collections.Generic;
using System.Threading;

public class ListingSession : Session
{
    private List<string> _prompts = new List<string>
    {
        "List some things you are grateful for.",
        "List some personal achievements you are proud of.",
        "List things that make you happy.",
        "List challenges you've overcome recently."
    };

    public ListingSession()
        : base("Listing")
    {
        _description = "This activity will help you list positive things in your life.";
    }

    public void Run()
    {
        ShowIntro(_nameOfSession, _description);

        string prompt = GetRandomPrompt();
        DisplayPrompt(prompt);

        Console.WriteLine("You have some time to list as many things as you can...");
        ShowSpinner(10); // Adjust countdown duration as needed

        List<string> responses = GetUserResponses();
        DisplayFollowUp(responses);

        ShowEnding();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    private void DisplayPrompt(string prompt)
    {
        Console.WriteLine($"\nPrompt: {prompt}");
    }

    private List<string> GetUserResponses()
    {
        List<string> responses = new List<string>();
        Console.WriteLine("Start listing your responses (type 'done' to finish):");

        while (true)
        {
            string response = Console.ReadLine();
            if (response.ToLower() == "done")
                break;
            responses.Add(response);
        }

        return responses;
    }

    private void DisplayFollowUp(List<string> responses)
    {
        Console.WriteLine("\nGreat job! Here's what you listed:");
        foreach (string response in responses)
        {
            Console.WriteLine($"- {response}");
        }
    }
}