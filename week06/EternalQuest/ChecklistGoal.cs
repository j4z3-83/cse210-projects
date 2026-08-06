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

    public ChecklistGoal (string name, string description, int points, int bonus, int target, int achieved) : base (name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = achieved;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;
        return GetPointsTotal();
    }

    public override int GetPointsTotal()
    {
        int bonusPoints = 0;
        if (_amountCompleted >= _target)
        {
            bonusPoints = _bonus;
        }
        return base.GetPointsTotal() + bonusPoints;
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
        string details;
        if (IsComplete() != true)
        {
            details = $"[ ] {GetGoalName()} ({GetGoalDescription()}) -- goal completed {_amountCompleted}/{_target}";
        }
        else
        {
            details = $"[X] {GetGoalName()} ({GetGoalDescription()}) -- goal completed {_amountCompleted}/{_target}";
        }
        return details;
    }

    public override string GetStringRepresentation()
    {
        return $"{this.GetType().Name},{GetGoalName()},{GetGoalDescription()},{GetPointsTotal()},{_bonus},{_target},{_amountCompleted}";
    }
}