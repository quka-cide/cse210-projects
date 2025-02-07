using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Activity activity = new Activity("Breathing", "description", 30);
        activity.DisplayStartingMessage();
        activity.DisplayEndingMessage();
        activity.ShowSpinner(10);
        activity.ShowCountDown(10);
    }
}