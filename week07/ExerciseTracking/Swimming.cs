public class Swimming : Activity
{

    public Swimming(string date, int duration) : base (date, duration)
    {

    }


    public override float GetDistance()
    {
        int duration = GetDuration();
        float time = duration / 60.0f;
      
        float distance = GetSpeed() * time;
        float fLaps = distance * 1000 / 50;
        int laps = (int)fLaps;
        return laps;
    }

    public override float GetSpeed()
    {
        Random rand = new Random();
        float minS = 1.60f;
        float maxS = 3.20f;
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
        string summary = $"{GetDate()} {GetActivity()} ({GetDuration()} min): Distance {GetDistance()} laps, Speed {GetSpeed():F2} km/h, Pace {GetPace():F2} min per lap";

        return summary;
    }
}