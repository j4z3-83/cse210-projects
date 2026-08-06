using System.Data;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    private int _level = 1;

    private int _levelTracker = 0;

    public GoalManager(){}
    
    public void Start()
    {
        string option = "";
        while (option != "6")
        {

            DisplayPlayerInfo();
            Console.WriteLine();
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
                Console.Clear();
                Console.WriteLine("Your goals are:");
                ListGoalDetails();
                Console.WriteLine();
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
                RecordEvent();
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
        Console.WriteLine();
    }

    public void ListGoalNames()
    {
        int i = 1;

        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetGoalName()}");
            i++;
        }
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
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
        int selectedGoal;
        int levelThreshold = 1000;
        
        Console.Clear();
        Console.WriteLine("Your goals are:");
        Console.WriteLine();
        
        ListGoalNames();

        Console.WriteLine();
        Console.WriteLine("Which goal have you completed? ");
        selectedGoal = int.Parse(Console.ReadLine()); 

        Goal goal = _goals[selectedGoal - 1];
        int points= goal.RecordEvent();
        _score += points;
        _levelTracker += points;
        Console.WriteLine($"Congratulations you have earned {points} points.");

        if(_levelTracker >= 500)
        {
            _level++;
            Console.WriteLine("YOU HAVE GAINED A LEVEL!");
            Console.WriteLine("Keep up the hard work.");

            _levelTracker = _levelTracker - levelThreshold;
        }

        Thread.Sleep(3000);
    }

    public void SaveGoals()
    {
        string filename;
        Console.WriteLine();
        Console.WriteLine("What is the name of the file you would like to save? ");
        filename = Console.ReadLine();
        
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
        string filename;
        string goalType;
        string goalName;
        string goalDescription;
        int goalPoints;
        bool goalCompleted;
        int goalBonus;
        int goalTarget;
        int goalAchived;

        Console.WriteLine();
        Console.WriteLine("What is the name of the file you would like  to load? ");
        filename = Console.ReadLine();

        //load score and level
        string[] lines = System.IO.File.ReadAllLines(filename);

        string[] line1 = lines[0].Split(",");
        _score = int.Parse(line1[0]);
        _level = int.Parse(line1[1]);

        //load goals
        lines = System.IO.File.ReadAllLines(filename).Skip(1).ToArray();
        
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            goalType = parts[0];
            if (goalType == "SimpleGoal")
            {                
                goalName = parts[1];
                goalDescription = parts[2];
                goalPoints = int.Parse(parts[3]);
                goalCompleted = bool.Parse(parts[4]);

                SimpleGoal sg = new SimpleGoal(goalName, goalDescription, goalPoints, goalCompleted);
                _goals.Add(sg);                
            }
            else if (goalType == "EternalGoal")
            {
                goalName = parts[1];
                goalDescription = parts[2];
                goalPoints = int.Parse(parts[3]);

                EternalGoal eg = new EternalGoal(goalName, goalDescription, goalPoints);
                _goals.Add(eg);                
            }
            else
            {
                goalName = parts[1];
                goalDescription = parts[2];
                goalPoints = int.Parse(parts[3]);
                goalBonus = int.Parse(parts[4]);
                goalTarget = int.Parse(parts[5]);
                goalAchived = int.Parse(parts[6]);

                 ChecklistGoal cg = new ChecklistGoal(goalName, goalDescription, goalPoints, goalBonus, goalTarget, goalAchived);
                _goals.Add(cg);                
            }            
        }
    }
}