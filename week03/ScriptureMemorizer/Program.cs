// Added feature to ask user for scripture.
using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter reference: ");
        string userReference = Console.ReadLine();
        string[] referenceArr = userReference.Split(new Char[] { ' ', ':', '-' });
        
        string book = referenceArr[0];
        int chapter = int.Parse(referenceArr[1]);
        int verse = int.Parse(referenceArr[2]);

        Reference reference = null;
        if (referenceArr.Length == 3)
        {
            reference = new Reference(book, chapter, verse);
        }
        else if (referenceArr.Length == 4)
        {
            int endVerse = int.Parse(referenceArr[3]);
            reference = new Reference(book, chapter, verse, endVerse);
        }

        Console.WriteLine("Enter scripture verse(s):");
        string scriptureText = Console.ReadLine();
        // string scriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        Scripture scripture = new Scripture(reference, scriptureText);

        while(true)
        {
            Console.Clear();

            Console.WriteLine($"{reference.GetDisplayText()} {scripture.GetDisplayText()}");

            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();
            
            if (scripture.IsComplitelyHidden())
            {
                break;
            }

            if (input == "quit")
            {
                break;
            }

            if (string.IsNullOrEmpty(input))
            {
                scripture.HideRandomWords(3);
            }           

           
        }
    }
}