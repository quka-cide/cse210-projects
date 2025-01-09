using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        string valueFromUser = Console.ReadLine();
        int num = int.Parse(valueFromUser);

        string letter = "";

        if (num >= 90)
        {
            letter = "A";
        }
        else if (num >= 80)
        {
            letter = "B";
        }
        else if (num >= 70)
        {
            letter = "C";
        }
        else if (num >= 60)
        {
            letter = "D";
        }
        else if (num < 60)
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is: {letter}");

        if (num >= 70)
        {
            Console.WriteLine("Congrats! You passed");
        }
        else {
            Console.WriteLine("Better luck next time!");
        }
    }
}
