using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int num = -1;
        List<int> numbers = new List<int>();
        while (num != 0)
        {
        Console.Write("Enter number: ");
        string userInput = Console.ReadLine();
        num = int.Parse(userInput);
        if (num != 0)
        {
            numbers.Add(num);
        }
        }

        int sum = 0;
        int largest = 0;
        foreach (int number in numbers)
        {
            sum += number;
            if (number > largest)
            {
                largest = number;
            }
        }

        int len = numbers.Count;
        float average = ((float)sum) / len;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}