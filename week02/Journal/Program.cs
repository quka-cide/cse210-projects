// Added methods to save and load journal entries using JSON for storage.
using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime theCurrentTime = DateTime.Now;
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program!");

        int choice = 0;
        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("4. Quit");
            Console.Write("What would you like to do? ");
            string userNum = Console.ReadLine();
            choice = int.Parse(userNum);

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Your response: ");
                string userResponse = Console.ReadLine();
                Entry entry = new Entry
                {
                    _date = theCurrentTime.ToShortDateString(),
                    _promptText = prompt,
                    _enteryText = userResponse
                };
                journal.AddEntry(entry);
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.WriteLine("What is the filename?");
                string loadFile = Console.ReadLine();
                journal.LoadFromJson(loadFile);
            }            
            else if (choice == 4)
            {
                Console.WriteLine("What is the filename?");
                string saveFile = Console.ReadLine();
                journal.SaveToJson(saveFile);
            }
        }
    }
}