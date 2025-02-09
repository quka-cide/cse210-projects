//added feature to keeping a log of how many times activities were performed
using System;

class Program
{
    static void Main(string[] args)
    {
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;
        int userInput = 0;

        while (userInput != 4) {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = int.Parse(Console.ReadLine());
            
            switch (userInput) 
            {
                case 1:
                    breathingCount++;
                    BreathingActivity breathingActivity = new BreathingActivity(20);
                    Console.Clear();
                    breathingActivity.Run();
                    break;
                case 2:
                    reflectingCount++;
                    ReflectingActivity reflectingActivity = new ReflectingActivity(20);
                    Console.Clear();
                    reflectingActivity.Run();
                    break;
                case 3:
                    listingCount++;
                    ListingActivity listingActivity = new ListingActivity(20);
                    Console.Clear();
                    listingActivity.Run();
                    break;
                case 4:
                    Console.WriteLine("\nSession Summary:");
                    Console.WriteLine($"- Breathing activities completed: {breathingCount}");
                    Console.WriteLine($"- Reflecting activities completed: {reflectingCount}");
                    Console.WriteLine($"- Listing activities completed: {listingCount}");
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
}