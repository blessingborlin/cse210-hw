public  abstract class Activity
{
    private DateTime _date;

    private int _Length;

    public Activity(DateTime date, int length)
    {
        _date = date;
        _Length = length;
      
    }
    protected string GetLength()
    {
        return _Length;
    }
    public  abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetSummary()
     {
        return $"{_date:dd MMM yyyy} {GetActivityName()} ({_Length} min): " +
               $"Distance {GetDistance():0.0} miles, " +
               $"Speed: {GetSpeed():0.0} mph, " +
               $"Pace: {GetPace():0.0} min per mile";
    }

    protected abstract string GetActivityName();
    
}