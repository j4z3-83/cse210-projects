using System.Dynamic;
using System.Runtime.CompilerServices;

public abstract class Activity
{
    private string _date;
    private int _duration;
    private float _speed;
    private string _activity;


    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }


    public abstract float GetDistance();

    public abstract  float GetSpeed();

    public abstract float GetPace();

    public virtual string GetSummary()
    {
        string summary = "";

        return summary;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public string GetActivity()
    {
        return _activity;
    }

    public void SetActivity(string activity)
    {
        _activity = activity;
    }

    public float GetRandSpeed()
    {
        return _speed;
    }

    
}