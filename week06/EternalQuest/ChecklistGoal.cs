public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal (string name, string description, int points, int target, int bonus) : base (name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {

        return GetPointsTotal();
    }

    public override bool IsComplete()
    {
        bool isComplete = false;
        if (_amountCompleted >= _target)
        {
            isComplete = true;
        }
        return isComplete;
    }

    public override string GetDetailsString()
    {
        string details = "test";
        return details;
    }

    public override string GetStringRepresentation()
    {
        
        string stringRepresentation = "";
        string name = GetGoalName();
        string description = GetGoalDescription();
        int points = GetPointsTotal();
 
        stringRepresentation = $"{this.GetType().Name}, {name}, {description}, {points}, {IsComplete()} {_bonus}, {_target}, {_amountCompleted}"; 
      
        return stringRepresentation;
    }
}