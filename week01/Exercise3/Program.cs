using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 100);

        int userNum = -1;

        while (userNum != magicNum)
        {
            Console.Write(" What is your guess? ");
            string userGuess = Console.ReadLine();
            userNum = int.Parse(userGuess);

            if (userNum < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else if (userNum > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}