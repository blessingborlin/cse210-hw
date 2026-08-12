public class Swimming : Activity
{
    private int _laps;
    private const double LapLength = 50 ;

    public Swimming(DateTime date, int length, int laps): base(date , length)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return _laps * LapLength / 1000;
    }
    public override double GetSpeed()
    {
        return GetDistance() / _length * 60;
    }
    public override double GetPace()
    {
        return _length /GetDistance();
    }
    public override string GetActivityName()
    {
        return "Swimming";
    }
    
}
