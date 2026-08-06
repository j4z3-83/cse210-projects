using System.Diagnostics.Tracing;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    private int _level = 1;

    public GoalManager(){}
    
    public void Start()
    {

        string option = "";
        while (option != "6")
        {

            DisplayPlayerInfo();
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write ("Select an option from the menu: ");
            option = Console.ReadLine();

            if (option == "1")// create new goal
            {
                CreateGoal();
            }
            else if (option == "2")//display list of goals
            {
              
            }
            else if (option == "3")// save goal to file
            {
                SaveGoals();
            }
            else if (option == "4")// load goal from file
            {
                LoadGoals();
            }
            else if (option == "5")// record goal event
            {
            
            }
            else if (option == "6")// exit program
            {
                break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your points total is: {_score}");
        Console.WriteLine($"Your current level is: {_level}");
        Console.WriteLine("");
    }

    public void ListGoalNames()
    {

    }

    public void ListGoalDetails()
    {

    }

    public void CreateGoal()
    {
        string goal = "";

        while (goal != "1" || goal != "2" || goal != "3")
        {
            Console.Clear();
            Console.WriteLine("The Available Goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            goal = Console.ReadLine();
            if (goal == "1")
            {
                Console.Write("Enter the Name of your goal: ");
                string name = Console.ReadLine();
                Console.Write("Enter a short description of this goal: ");
                string description = Console.ReadLine();
                Console.Write("Enter the points value of this goal: ");
                int points = int.Parse(Console.ReadLine());
                SimpleGoal sg = new SimpleGoal(name, description, points);
                _goals.Add(sg);
                Console.WriteLine("Goal Created");
                Thread.Sleep(2000);
                break;
            }
            else if (goal == "2")
            {
                Console.Write("Enter the Name of your goal: ");
                string name = Console.ReadLine();
                Console.Write("Enter a short description of this goal: ");
                string description = Console.ReadLine();
                Console.Write("Enter the points value of this goal: ");
                int points = int.Parse(Console.ReadLine());
                EternalGoal eg = new EternalGoal(name, description, points);
                _goals.Add(eg);
                Console.WriteLine("Goal Created");
                Thread.Sleep(2000);
                break;
            }
            else if (goal == "3")
            {
                Console.Write("Enter the Name of your goal: ");
                string name = Console.ReadLine();
                Console.Write("Enter a short description of this goal: ");
                string description = Console.ReadLine();
                Console.Write("Enter the points value of this goal: ");
                int points = int.Parse(Console.ReadLine());
                Console.Write("Enter the number of times you want to accomplish this goal: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus points for completing this goal: ");
                int bonus = int.Parse(Console.ReadLine());            
                ChecklistGoal cg = new ChecklistGoal(name, description, points, target, bonus);
                _goals.Add(cg);
                Console.WriteLine("Goal Created");
                Thread.Sleep(2000);
                break;
            }
            else
            {
                Console.WriteLine("Invalid response please enter a valid number.");
                Thread.Sleep(2000);
            }
        }        
    }

    public void RecordEvent()
    {
        
    }

    public void SaveGoals()
    {
        string filename = "myFile.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"{_score}, {_level}");
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());            
            }
        }
    }

    public void LoadGoals()
    {

                
        
    }
}