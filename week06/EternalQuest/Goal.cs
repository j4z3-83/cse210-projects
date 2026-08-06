using System.Runtime.CompilerServices;

public abstract class Goal
{
    private string _goalName;
    private string _goalDescription;
    private int _pointsTotal;
  

    public Goal(string name, string description, int points)
    {
        _goalName = name;
        _goalDescription = description;
        _pointsTotal = points;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetDetailsString();


    public abstract string GetStringRepresentation();
        public virtual int GetPointsTotal()
    {
        return _pointsTotal;
    }

    public string GetGoalName()
    {
        return _goalName;
    }

    public string GetGoalDescription()
    {
        return _goalDescription;
    }



   
}