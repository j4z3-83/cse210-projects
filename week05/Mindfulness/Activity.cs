using System.Runtime.CompilerServices;
using System.Security.Cryptography;

public class Activity
{
    //Member variables
    protected string _name;
    protected string _description;
    protected int _duration;
    protected List<string> _animStrings = new List<string>
    {
        "|",
        "/",
        "-",
        "\\",
    };
    
    //Constructor
    public Activity()
    {
      
    }

    //Methods/Functions
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine ($"This is the {_name}");
        Console.WriteLine ($"{_description}\n");
        if (_name == "Breathing Activity")
        {
            Console.Write("How many cycles would you like to complete? ");
            _duration = int.Parse(Console.ReadLine()); 
        }
        else
        {
            Console.Write("How long in seconds would you like to spend on this activity? ");
            _duration = int.Parse(Console.ReadLine()); 
        }

        Console.Clear();
        Console.WriteLine("Preparing activity");
        ShowSpinner(5);
    }
    public void DisplayEndingMessage()
    {
        Console.Clear();
        Console.WriteLine($"You have successfully completed the {_name}");         
    }

    public void ShowSpinner(int newSeconds)
    {
        int i = 0;
        int seconds = newSeconds;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        
        while (DateTime.Now < endTime)
        {
            String s = _animStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= _animStrings.Count)
            {
                i=0;
            }
        }    
    }
     

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
    }

    //Getters and setters
    public String GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void SetName (string name)
    {
        _name = name;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
}