/* This class will load and save the entries as well as call on the entries class to make new ones.
It will also display the all the entries.
 */
using System.IO;
public class Journal
{
    List<Entry> _entries = [];

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
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~|~{entry._promptText}~|~{entry._entryText}~|~{entry._entryBook}");
            }

        }
        Console.WriteLine($"Loaded {file}");
    }
    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];
            entry._entryBook = parts[3];
            _entries.Add(entry);
        }

        Console.WriteLine($"Loaded {file}");
    }
}
