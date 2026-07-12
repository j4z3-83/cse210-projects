using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    //member variable
    public List<Entry> _entries = new List<Entry>();
    Entry anEntry = new Entry();

    //member functions
    public void AddEntry(Entry newEntry)
    {
        
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            anEntry.Display(entry._date, entry._promptText, entry._entryText);
        } 
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter (file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~~{entry._promptText}~~{entry._entryText}");         
            }   
        }
        Console.WriteLine("File saved.");
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        //line will have {date}~~{promptText}~~{entryText}    
        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");
            //parts[0] - {date}
            //parts[1] - {promptText}
            //Parts[2] - {entryText}
            Entry loadedEntry = new Entry();
            loadedEntry._date = parts[0];
            loadedEntry._promptText = parts[1];
            loadedEntry._entryText = parts[2];

            AddEntry(loadedEntry);
        }
        Console.WriteLine("File Loaded");
    }
}

