using System.Runtime.Serialization;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        while (true)
        {
            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    return;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        int i = 1;
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetStringRepresentation()}");
            i++;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case 2:
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int amountToComplete = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, amountToComplete, bonus));
                break;
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int userInput = int.Parse(Console.ReadLine());
        _goals[userInput - 1].RecordEvent();
        int points = _goals[userInput - 1].GetPoints();
        _score += points;
        Console.WriteLine($"You now have {_score} points!");
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string fullPath = $"C:/Users/user/Documents/cse210-projects/week06/EternalQuest/{filename}";

        using (StreamWriter writer = new StreamWriter(fullPath))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                if (goal.GetType().Name == "SimpleGoal")
                {
                    string line = string.Join(",", goal.GetType().Name, goal.GetName(), goal.GetDescription(), goal.GetPoints(), goal.IsComplete());
                    writer.WriteLine(line);
                }
                if (goal.GetType().Name == "EternalGoal")
                {
                    string line = string.Join(",", goal.GetType().Name, goal.GetName(), goal.GetDescription(), goal.GetPoints());
                    writer.WriteLine(line);
                }
                if (goal.GetType().Name == "ChecklistGoal")
                {
                    ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                    string line = string.Join(",", goal.GetType().Name, goal.GetName(), goal.GetDescription(), goal.GetPoints(), checklistGoal.GetBonus(), checklistGoal.GetAmountCompleted(), checklistGoal.GetTarget());
                    writer.WriteLine(line);
                }            
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string fullPath = $"C:/Users/user/Documents/cse210-projects/week06/EternalQuest/{filename}";

        _goals.Clear();
        using (StreamReader reader = new StreamReader(fullPath))
        {
            _score = int.Parse(reader.ReadLine());

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(",");
                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                if (type == "SimpleGoal")
                {
                    bool isComplete = bool.Parse(parts[4]);
                    SimpleGoal goal = new SimpleGoal(name, description, points);
                    goal.SetIsComplete(isComplete);
                    _goals.Add(goal);
                }
                else if (type == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(name, description, points));
                }
                else if (type == "ChecklistGoal")
                {
                    int bonus = int.Parse(parts[4]);
                    int completed = int.Parse(parts[5]);
                    int target = int.Parse(parts[6]);
                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                    checklistGoal.SetAmountCompleted(completed);
                    _goals.Add(checklistGoal);
                }
            }
        }
    }
}
