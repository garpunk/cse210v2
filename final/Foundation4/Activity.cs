public class Activity
{
    private int _time; // in minutes
    private string _date;

    public Activity(string date, int time)
    {
        _date = date;
        _time = time;
    }

    public int GetTime()
    {
        return _time;
    }

    public string GetDate()
    {
        return _date;
    }

    public virtual double GetDistance()
    {
        return 0.0;
    }

    public virtual double GetSpeed()
    {
        return 0.0;
    }

    public virtual double GetPace()
    {
        return 0.0;
    }

    public virtual string GetSummary()
    {
        return _date + " Activity (" + _time + " min)";
    }
}