public class CyclingActivity : Activity
{
    private double _speed; // in mph

    public CyclingActivity(string date, int time, double speed) : base(date, time)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return (_speed * GetTime()) / 60;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
      return $"{GetDate()} Cycling ({GetTime()} min) - Distance: {GetDistance():F1} miles, Speed: {_speed:F1} mph, Pace: {GetPace():F2} min per mile";

    }
}