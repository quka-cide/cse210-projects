using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WriteAssignment writeAssignment = new WriteAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writeAssignment.GetWritingInformation());
    }
}