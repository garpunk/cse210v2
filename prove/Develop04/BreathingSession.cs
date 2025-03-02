using System.Reflection;

public class BreathingSession : Session
{
    public BreathingSession() : base("Breathing")
    {
        _description = "This activity will help you relax by guiding your breathing.";
    }

    public void Run()
    {
        ShowIntro(_nameOfSession, _description);

        for (int i = 5; i > 0; i--) // Countdown from 5
        {
            Console.Write("Breathe in... ");
            Countdown(3);
            Console.Write("Breathe out... ");
            Countdown(3);
        }

        ShowEnding();
    }

    private void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}