public class Cycling : Activity
{
    private double _Speed;
     
    public Cycling(DateTime date, int length, double Speed): base(date, length)
    {
        _Speed = Speed;
    }
    public override double GetDistance()
    {
        return _Speed * _length / 60 ;
    
    }
    public override double GetSpeed()
    {
        return _Speed;
    }
    public override double GetPace()
    {
        return 60 / _Speed;
    }
    public override string GetActivityName()
    {
        return "Cycling";
    }

}