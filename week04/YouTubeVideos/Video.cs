public class Video
{
    public string _title;
    public string _author;
    public int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    } 
    public void AddComments(string author, string text)
    {
        _comments.Add(new Comment(author, text));
    }
    public int NumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nLength: {_length} seconds\nComments ({NumberOfComments()}):");
        foreach (var comment in _comments)
        {
            Console.WriteLine($"- {comment._authorName}: {comment._text}");
        }
        Console.WriteLine();
    }
}