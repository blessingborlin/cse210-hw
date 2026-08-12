using System.Diagnostics;

public class Running : Activity
{
    private double  _distance;

    public Running(DateTime date, int length, double distance): base( date, length)
    {
        _distance = distance;
    }
    public override GetDistance()
    {
        return _distance;

    }
    public override double GetSpeed()
    {
        return _distance / GetLength() * 60;
    }
    public override double GetPace()
    {
      return GetLength()/_distance;
    
    }
    protected override string GetActivityName()
    {
        return "Running";
    }

    
}