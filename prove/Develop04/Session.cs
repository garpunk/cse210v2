public class Session {
    protected string _startingMessage;

    protected string _nameOfSession;

    protected string _time;

    protected string _description;

    protected int duration;

    public Session(string name)
    {
        _nameOfSession = name;
    }

    public void ShowIntro(string name, string description)
    {
        _nameOfSession = name;
        _description = description;
        Console.WriteLine($"Starting {_nameOfSession} Session\n {_description}");
        Console.Write("How long would you like this session to last? (seconds): ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin");
        ShowSpinner(3);
    }

      public void ShowEnding()
    {
        
        Console.WriteLine("Good job!");
        Console.WriteLine($"You completed the {_nameOfSession} session for {duration} seconds.");
        ShowSpinner(3);
    }

     public void ShowSpinner(int seconds)
    {
    

        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
             Console.Write(s);
            Thread.Sleep(1000);
             Console.Write("\b \b");

             i++;

             if (i >= animationStrings.Count)
             {
                i = 0;
             }
        }
        Console.WriteLine();
    }

    public void ShowCountdown(int seconds)
{
   for (int i = seconds; i > 0; i--)
    {
        Console.Write($"\r{i}   "); 
        Thread.Sleep(1000);
    }
    Console.WriteLine();
}

   

   
    
  

    
}