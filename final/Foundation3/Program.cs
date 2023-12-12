using System;

class Program
{
    static void Main(string[] args)
    {

        // Create addresses
        Address address1 = new Address("123 Main St", "Cityville", "CA", "USA");
        Address address2 = new Address("456 Oak St", "Townsville", "NY", "USA");
        Address address3 = new Address("789 Pine St", "Villageland", "ON", "Canada");

        // Create events
        Event genericEvent = new Event("Generic Event", "A generic event", DateTime.Now.AddDays(10), new TimeSpan(14, 30, 0), address1);
        Lecture lectureEvent = new Lecture("Tech Talk", "An informative tech talk", DateTime.Now.AddDays(20), new TimeSpan(18, 0, 0), address2, "John Doe", 50);
        Reception receptionEvent = new Reception("Networking Mixer", "A networking event", DateTime.Now.AddDays(15), new TimeSpan(19, 0, 0), address3, "rsvp@example.com");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Park Picnic", "A casual picnic", DateTime.Now.AddDays(25), new TimeSpan(12, 0, 0), address1, "Sunny day expected");

        // Display marketing messages
        Console.WriteLine("Generic Event:\n" + genericEvent.GetStandardDetails());
        Console.WriteLine("\nLecture Event:\n" + lectureEvent.GetFullDetails());
        Console.WriteLine("\nReception Event:\n" + receptionEvent.GetFullDetails());
        Console.WriteLine("\nOutdoor Event:\n" + outdoorEvent.GetFullDetails());

        Console.WriteLine("");
    }
}