public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, int points) : base (name, description, points)
    {
        _isComplete = false;
    }

    public SimpleGoal(string name, string description, int points, bool completed) : base (name, description, points)
    {
        _isComplete = completed;
    }

    public bool GetIsComplete()
    {
        return _isComplete;
    }

    public override int RecordEvent()
    {
        _isComplete = IsComplete();
        return GetPointsTotal();
    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetDetailsString()
    {
        string details;
        if (_isComplete != true)
        {
            details = $"[ ] {GetGoalName()} ({GetGoalDescription()})";
        }
        else
        {
            details = $"[X] {GetGoalName()} ({GetGoalDescription()})";
        }
        return details;
    }
    

    public override string GetStringRepresentation()
    {
        return $"{this.GetType().Name},{GetGoalName()},{GetGoalDescription()},{GetPointsTotal()},{_isComplete}";
    }




}