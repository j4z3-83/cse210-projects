using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class ReflectingActivity : Activity
{
    //Members variables
    private List<string> _prompts = new List<String>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    int _promptIndex = 0; 
    private List<string> _questions = new List<String>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    int _questionsIndex = 0;

    //Constructor
    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will allow you to reflect on time in your past when you have show inner strength and resilience. This will help you to recognize the your power and how you can use it in all aspects of your life.";
        Random.Shared.Shuffle(CollectionsMarshal.AsSpan(_prompts));
        Random.Shared.Shuffle(CollectionsMarshal.AsSpan(_questions));
        
    }

    //Methods/Functions
    public void Run()
    {
        string continueActivity = "y";

        while(continueActivity != "n")
        {
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);
            Console.Clear();
            Console.WriteLine(GetRandomPrompt());
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Press 'Enter' when you are ready to begin.");
            Console.ReadLine();
            while (DateTime.Now < endTime)
            {
                Console.WriteLine(GetRandomQuestion());
                Console.WriteLine("");

                ShowSpinner(10);
            }
            Console.WriteLine("Would you like to do this activity again y/n ");
            string textToLower = Console.ReadLine();
            continueActivity = textToLower.ToLower();
        }
    }

    public string GetRandomPrompt()
    {   
        int number = _prompts.Count;
        string prompt = _prompts[_promptIndex];
        _promptIndex++;
        if (_promptIndex == number)
        {
            _promptIndex = 0;
        }
        return prompt;
    }
    public string GetRandomQuestion()
    {
        int number = _questions.Count;
        string question = _questions[_questionsIndex];
        _questionsIndex++;
        if (_questionsIndex == number)
        {
            _questionsIndex = 0;
        }
        return question;
    }

     
}