using System;

public class Entry
{
    //member variables
    public String _date;
    public String _promptText;
    public String _entryText;
    

    //member functions
        public void Display(string date, string prompt, string response)
    {
        Console.WriteLine("");
        Console.WriteLine($"Date: {date} - Prompt: {prompt}");
        Console.WriteLine(response);
    }
}