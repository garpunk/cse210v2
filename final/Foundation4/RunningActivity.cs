public class RunningActivity : Activity
{
    private double _distance; // in miles

    public RunningActivity(string date, int time, double distance) : base(date, time)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetTime()) * 60;
    }

    public override double GetPace()
    {
        return GetTime() / _distance;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetTime()} min) - Distance: {_distance:F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F2} min per mile";
    }
}