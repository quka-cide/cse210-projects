public abstract class Activity
{
    private DateTime _date;
    private int _length;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public int GetLength()
    {
        return _length;
    }

    public void GetSummary()
    {
        Console.WriteLine($"{_date.ToString("dd MMM yyyy")} {GetType().Name} ({_length} min): Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km");
    }
}