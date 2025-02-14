public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int  _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public void SetAmountCompleted(int completed)
    {
        _amountCompleted = completed;
    }

    public int GetTarget()
    {
        return _target;
    }

    public int GetBonus()
    {
        return _bonus;
    }
    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            int totalPoints = GetPoints();
            if (_amountCompleted == _target)
            {
                totalPoints += _bonus;
                SetPoints(totalPoints);
            }
            Console.WriteLine($"Congratulations! You have earned {totalPoints} points!");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted == _target;
    }

    public override string GetStringRepresentation()
    {
        return $"{(IsComplete() ? "[X]" : "[ ]")} {GetDetailsString()} -- Currently completed: {_amountCompleted}/{_target}";
    }
}
