using System.Data;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(int duration)
    {
        _name = "Activity";
        _description = "description";
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        int userDuration = int.Parse(Console.ReadLine());
        _duration = userDuration;
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(5);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinnerSymbols = new List<string>();
        spinnerSymbols.Add("|");
        spinnerSymbols.Add("/");
        spinnerSymbols.Add("-");
        spinnerSymbols.Add("\\");
        spinnerSymbols.Add("|");
        spinnerSymbols.Add("/");
        spinnerSymbols.Add("-");
        spinnerSymbols.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = spinnerSymbols[i];
            Console.Write(s);
            Thread.Sleep(750);
            Console.Write("\b \b");

            i++;
            if (i >= spinnerSymbols.Count) {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}