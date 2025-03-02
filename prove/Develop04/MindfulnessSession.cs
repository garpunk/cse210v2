public class MindfulnessSession : Session
{
    private List<string> _prompts = new List<string>
    {
        "Think about a time when you felt truly at peace.",
        "Reflect on a moment where you helped someone.",
        "What is something you are grateful for today?"
    };

    private List<string> _followUpQuestions = new List<string>
    {
        "Why does this memory stand out to you?",
        "How did this moment impact your life?",
        "What feelings did you experience during this time?"
    };

    public MindfulnessSession() : base("Mindfulness")
    {
        _description = "This activity will help you reflect on meaningful moments.";
        duration = 50; 
    }

    public void Run()
    {
        ShowIntro(_nameOfSession, _description);
        bool sessionRunning = true;

        while (sessionRunning)
        {
            string prompt = GetRandomPrompt();
            Console.WriteLine(prompt);
            ShowCountdown(10); // Countdown before response

            string followUp = GetRandomFollowUp();
            Console.WriteLine(followUp);
            ShowCountdown(10); // Time to reflect

            Console.Write("Would you like another prompt? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            if (response != "yes")
            {
                sessionRunning = false;
            }
        }

        ShowEnding();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    private string GetRandomFollowUp()
    {
        Random rand = new Random();
        return _followUpQuestions[rand.Next(_followUpQuestions.Count)];
    }
}
