using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was a moment today that made me feel grateful?",
        "What did I learn today that I didn't know before?",
        "How did I make someone's day better today?",
        "What challenge did I face today, and how did I overcome it?",
        "In what ways did I grow as a person today?",
        "How can I do better and be better from how I was today?",
        "In what ways could I have been more Christlike to my fellow man today?",
        "How did following gospel principles bless my life today?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}