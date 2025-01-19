using System.IO;
using System.Text.Json;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToJson(string file)
    {
        string fullPath = $"C:/Users/user/Documents/cse210-projects/week02/Journal/{file}";
        string json = JsonSerializer.Serialize(_entries, new JsonSerializerOptions {WriteIndented = true});
        File.WriteAllText(fullPath, json);
    }

    public void LoadFromJson(string file)
    {
        string fullPath = $"C:/Users/user/Documents/cse210-projects/week02/Journal/{file}";
        string json = File.ReadAllText(fullPath);
        _entries = JsonSerializer.Deserialize<List<Entry>>(json) ?? new List<Entry>();
    }
    // public void SaveToFile(string file)
    // {
    //     string fullPath = $"C:/Users/user/Documents/cse210-projects/week02/Journal/{file}";
    //     using (StreamWriter outputFile = new StreamWriter(fullPath))
    //     {
    //         foreach (Entry entry in _entries)
    //         {
    //             string text = $"Date: {entry._date} - Prompt: {entry._promptText}\n{entry._enteryText}";
    //             outputFile.WriteLine(text);
    //         }
    //     }
    // }

    // public void LoadFromFile(string file)
    // {
    //     string fullPath = $"C:/Users/user/Documents/cse210-projects/week02/Journal/{file}";

    //         string[] lines = File.ReadAllLines(fullPath);

    //     for (int i = 0; i < lines.Length; i += 2)
    //     {
    //         string metadataLine = lines[i];
    //         string userInputLine = lines[i + 1];

    //         string[] splitByPrompt = metadataLine.Split("- Prompt: ");
    //         string datePart = splitByPrompt[0].Replace("Date: ", "").Trim();
    //         string promptText = splitByPrompt[1].Trim();

    //         Entry entry = new Entry
    //         {
    //             _date = datePart,
    //             _promptText = promptText,
    //             _enteryText = userInputLine.Trim()
    //         };
            
    //         _entries.Add(entry);
    //     }
    // }
}


