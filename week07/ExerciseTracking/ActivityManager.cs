using System.ComponentModel.DataAnnotations;

public class ActivityManager
{
    List<Activity> _activities = new List<Activity>();
    private string _date;

    public ActivityManager(){}

    public void Start()
    {
        DateTime now = DateTime.Now;
        _date = now.ToString("dd/MMM/yyyy");
        
        CreateEntries();

        DisplayList();

    }

    private void CreateEntries()
    {        
        Running run1 = new Running(_date, GetRandDuration());
        _activities.Add(run1);

        Running run2 = new Running(_date, GetRandDuration());
        _activities.Add(run2);
        
        StationaryBicycles sB1 = new StationaryBicycles(_date, GetRandDuration());
        _activities.Add(sB1);

        StationaryBicycles sB2 = new StationaryBicycles(_date, GetRandDuration());
        _activities.Add(sB2);

        Swimming swim1 = new Swimming(_date, GetRandDuration());
        _activities.Add(swim1);

        Swimming swim2 = new Swimming(_date, GetRandDuration());
        _activities.Add(swim2);
    }

    private void DisplayList()
    {
        foreach (Activity activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }

    private int GetRandDuration()
    {
        Random rand = new Random();
        int randDuration = rand.Next(15, 60 + 1);
        return randDuration;
    }







}