public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base (name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        IsComplete();
        return GetPointsTotal();
    }

    public override bool IsComplete()
    {
        _isComplete = true;
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        string stringRepresentation = "";
        string name = GetGoalName();
        string description = GetGoalDescription();
        int points = GetPointsTotal();
        stringRepresentation = $"{this.GetType().Name}, {name}, {description}, {points}, {_isComplete}"; 
      
        return stringRepresentation;
    }




}