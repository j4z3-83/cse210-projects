using System;

public class Journal
{
    //member variable
    public List<Entry> _entries = new List<Entry>();
    Entry anEntry = new Entry();

    //member functions
    public void AddEntry(Entry newEntry)
    {
        
        
        Console.WriteLine(newEntry._date);
        Console.WriteLine(newEntry._promptText);
        Console.WriteLine(newEntry._entryText);
        
        
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}");
            Console.WriteLine(entry._entryText);
        } 
    }

    public void SaveToFile(string file)
    {
        
    }

    public void LoadFromFile(string file)
    {
        
    }
}

