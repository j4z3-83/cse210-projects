using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class ListingActivity : Activity
{
    //Member variables
    private int _count = 0;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"      
    };
    private List<string> _answers = new List<string>();
    int _promptIndex = 0;
    string _prompt; 

    //Constructor
    public ListingActivity()
    {
        
    }

    //Methods/Functions
    public void Run()
    {
        Random.Shared.Shuffle(CollectionsMarshal.AsSpan(_prompts));
        string continueActivity = "y";

        while(continueActivity != "n")
        {
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);
            Console.Clear();        
            GetRandomPrompt();
            Console.Write("you can enter you responses in: ");
            ShowCountDown(5);
            Console.WriteLine("");

            while (DateTime.Now < endTime)
            {
                _answers.Add(Console.ReadLine());
                _count++;
            }
            Console.WriteLine($"You gave {_count} responses.");
            Console.WriteLine("Would you like to do this activity again y/n ");
            string textToLower = Console.ReadLine();
            continueActivity = textToLower.ToLower();
        }
    }
    public void GetRandomPrompt()
    {
        int number = _prompts.Count;
        string prompt = _prompts[_promptIndex];
        _promptIndex++;
        if (_promptIndex == number)
        {
            _promptIndex = 0;
        }
        Console.WriteLine (prompt);        
    }
    
    public List<string> GetListFromUser()
    {
        return _prompts;
    }
}