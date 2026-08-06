public abstract class Goal
{
    private string _ShortName;
    private string _description;
    private string _points;
    
    public Goal(string ShortName, string description, string points)
    {
        _ShortName = ShortName;
        _description = description;
        _points = points;
    }
  
    public abstract void RecordEvent();

    public abstract bool IsComplete();
    
    public abstract string GetDetailsString();

    public  abstract string GetStringRepresentation();

}