using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2025, 2, 17), 30, 4.8),
            new Cycling(new DateTime(2025, 2, 17), 45, 20.0),
            new Swimming(new DateTime(2025, 2, 17), 30, 20)
        };

        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }
    }
}