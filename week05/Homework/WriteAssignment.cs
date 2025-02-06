public class WriteAssignment : Assignment
{
    private string _title;

    public WriteAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{GetSummary()}\n{_title}";
    }
}