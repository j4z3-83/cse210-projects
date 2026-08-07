using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;

public class Running : Activity
{
    public Running(string date, int duration) : base (date, duration)
    {

    }

    public override float GetDistance()
    {
        int duration = GetDuration();
        float time = duration / 60.0f;
      
        float distance = GetSpeed() * time;
        return distance;
    }

    public override float GetSpeed()
    {
        Random rand = new Random();
        float minS = 8.00f;
        float maxS = 10.00f;
        int minInt = (int)(minS * 100);
        int maxInt = (int)(maxS * 100);

        float speed = rand.Next(minInt, maxInt + 1) / 100f;

        return speed;
    }

    public override float GetPace()
    {
        float pace = GetDuration() / GetDistance();
        return pace;
    }

    public override string GetSummary()
    {
        SetActivity(this.GetType().Name);
        string summary = $"{GetDate()} {GetActivity()} ({GetDuration()} min): Distance {GetDistance():F2} km, Speed {GetSpeed():F2} km/h, Pace {GetPace():F2} min per km";
        return summary;
    }




        
    
}