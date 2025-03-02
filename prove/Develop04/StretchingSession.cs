public class StretchingSession : Session
{
    private List<string> _stretches = new List<string>
    {
        "Reach your arms up and stretch toward the ceiling.",
        "Roll your shoulders forward and backward slowly.",
        "Gently tilt your head from side to side.",
        "Stretch your arms across your chest one at a time.",
        "Stand up and touch your toes, keeping your knees slightly bent.",
        "Take a deep breath and gently twist your torso to each side."
    };

    public StretchingSession(string name) : base(name)
    {
        _nameOfSession = "Stretching & Moving";
        _description = "This activity will help you relax by guiding you through light stretches.";
    }

    public void Run()
    {
        ShowIntro(_nameOfSession, _description);

       

        Console.WriteLine("\nFollow along with these gentle stretches.\n");

        foreach (string stretch in _stretches)
        {
            Console.WriteLine(stretch);

             Console.WriteLine("\nGet ready to stretch!");
             ShowCountdown(5); // 5-second "Get Ready" countdown

            ShowCountdown(15); // Hold each stretch for 15 seconds
        }

        Console.WriteLine("\nGreat job! Your body appreciates the movement.");
        ShowEnding();
    }
}