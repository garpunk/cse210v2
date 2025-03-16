using System;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("123 Main St", "New York", "NY", "USA");
        Address addr2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Address addr3 = new Address("789 Park Ave", "Los Angeles", "CA", "USA");

        Lecture lecture = new Lecture("AI in 2025", "A discussion on the future of AI.", "March 20, 2025", "10:00 AM", addr1, "Dr. Jane Smith", 100);
        Reception reception = new Reception("Networking Event", "Meet industry professionals.", "April 5, 2025", "6:00 PM", addr2, "rsvp@example.com");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Spring Festival", "Enjoy outdoor activities!", "May 15, 2025", "12:00 PM", addr3, "Sunny and warm");

        Console.WriteLine(lecture.GetLectureDetails());
        Console.WriteLine("\n----------------------------\n");
        Console.WriteLine(reception.GetReceptionDetails());
        Console.WriteLine("\n----------------------------\n");
        Console.WriteLine(outdoorEvent.GetOutdoorDetails());
    }
}