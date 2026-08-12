public  abstract class Activity
{
    private DateTime _date;

    private int _length;

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
      
    }
    protected string GetLength()
    {
        return _length;
    }
    public  abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetSummary()
     {
        return $"{_date:dd MMM yyyy} {GetActivityName()} ({_length} min): " +
               $"Distance {GetDistance():0.0} miles, " +
               $"Speed: {GetSpeed():0.0} mph, " +
               $"Pace: {GetPace():0.0} min per mile";
    }

    protected abstract string GetActivityName();
    
}