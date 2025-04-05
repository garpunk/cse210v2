public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(string date, int time, int laps) : base(date, time)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0 * 0.62; 
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetTime()) * 60;
    }

    public override double GetPace()
    {
        return GetTime() / GetDistance();
    }

    public override string GetSummary()
    {
         return $"{GetDate()} Swimming ({GetTime()} min) - Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F2} min per mile";
    }
}