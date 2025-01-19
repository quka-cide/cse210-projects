public class Entry
{
    public string _date { get; set; }
    public string _promptText { get; set; }
    public string _enteryText { get; set; }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}\n{_enteryText}");
        Console.WriteLine();
    }
}