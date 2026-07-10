using System;

public class Entry
{
    //member variables
    public String _date;
    public String _promptText;
    public String _entryText;
    

    //member functions
        public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
    }
}