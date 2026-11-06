/* This class will be used to create new entries, get the date the entry was made, and 
use the Generate prompt class when a new entry is made.
*/

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _entryBook;

    public void Display()
    {
        Console.WriteLine("");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine(_entryText);
        Console.WriteLine(_entryBook);
    }
}