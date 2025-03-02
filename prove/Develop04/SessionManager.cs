using System;

public class SessionManager
{
    private bool _running = true; // Controls the main loop

    public void Run()
    {
        while (_running)
        {
            SessionMenu();
        }
    }

    private void SessionMenu()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness App!");
        Console.WriteLine("Select a session:");
        Console.WriteLine("1. Breathing Session");
        Console.WriteLine("2. Listing Session");
        Console.WriteLine("3. Mindfulness Session");  
        Console.WriteLine("4. Stretching & Moving Session");
        Console.WriteLine("5. Exit");
        Console.Write("Enter your choice: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                BreathingSession breathingSession = new BreathingSession();
                breathingSession.Run();
                break;

            case "2":
                ListingSession listingSession = new ListingSession();
                listingSession.Run();
                break;
            

                case "3":
                    MindfulnessSession mindfulnessSession = new MindfulnessSession(); // ✅ Create instance
                    mindfulnessSession.Run();
                    break;
             case "4":
                    StretchingSession stretchingSession = new StretchingSession("Stretching & Moving");
                    stretchingSession.Run();
                    break;

            case "5":
                _running = false;
                Console.WriteLine("Goodbye!");
                break;

            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }

        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
}
