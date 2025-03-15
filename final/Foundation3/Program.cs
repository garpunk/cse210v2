using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Elm St", "New York", "NY", "USA");
        Address address2 = new Address("456 Oak Rd", "Los Angeles", "CA", "USA");
        Address address3 = new Address("789 Pine Ave", "Seattle", "WA", "USA");

        // Create events
        Lecture lecture = new Lecture(
            "Tech Innovation Summit",
            "A discussion on the future of technology.",
            "April 10, 2025",
            "10:00 AM",
            address1,
            "Dr. John Smith",
            150);

        Reception reception = new Reception(
            "Networking Gala",
            "An evening of networking with industry leaders.",
            "May 15, 2025",
            "7:00 PM",
            address2,
            "rsvp@eventplanner.com");

        OutdoorGathering outdoorGathering = new OutdoorGathering(
            "Spring Festival",
            "Enjoy live music and local food vendors.",
            "June 20, 2025",
            "3:00 PM",
            address3,
            "Sunny with a high of 75°F");

        // Display event details
        DisplayEventDetails(lecture);
        DisplayEventDetails(reception);
        DisplayEventDetails(outdoorGathering);
    }

    static void DisplayEventDetails(Event ev)
    {
        Console.WriteLine(ev.GetStandardDetails());
        Console.WriteLine(ev.GetFullDetails());
        Console.WriteLine(ev.GetShortDescription());
        Console.WriteLine("--------------------------------------\n");
    }
}
