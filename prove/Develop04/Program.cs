using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");

        
        SessionManager sessionManager = new SessionManager();
        sessionManager.Run(); 
    }
}
