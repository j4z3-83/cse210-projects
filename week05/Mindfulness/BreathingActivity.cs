public class BreathingActivity : Activity
{
    //Constructor
    public BreathingActivity()
    {
        
    }

    //Methods/Functions
    public void Run()
    {
        string continueActivity = "y";

        while (continueActivity != "n")
        {
            int cycles = 0;
        
            while (cycles < _duration)
            {
                Console.Clear();
                Console.Write("Breathe in ");
                ShowCountDown(4);
                Console.Write("\nHold ");
                ShowCountDown(4);
                Console.Write("\nBreathe out ");
                ShowCountDown(4);
                Console.Write("\nhold ");
                ShowCountDown(4);
                cycles++;
            }
            Console.WriteLine("Would you like to do this activity again y/n ");
            string textToLower = Console.ReadLine();
            continueActivity = textToLower.ToLower();
        }
    }
}