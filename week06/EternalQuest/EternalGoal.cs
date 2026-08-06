using System.Runtime.CompilerServices;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base (name, description, points)
    {
        
    }

    public override int RecordEvent()
    {

        return GetPointsTotal();
    }

    public override bool IsComplete()
    {
        bool status = false;
        return status;
    }

    public override string GetStringRepresentation()
    {
        string stringRepresentation = "";
        string name = GetGoalName();
        string description = GetGoalDescription();
        int points = GetPointsTotal();
        stringRepresentation = $"{this.GetType().Name}, {name}, {description}, {points}"; 

        return stringRepresentation;   
    }
}