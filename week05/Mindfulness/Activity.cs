public class Activity
{
    private string _name;
    private string _description;
    private int  _duration;

    public Activity(string name, string description , int duration)
    {
        _name = name;
        _description= description;
        _duration=duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($" Welcome to {_name}  Activity.");
        Console.WriteLine(_description);
    
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Thanks for finishing {_name}  Activity.");
        Console.WriteLine(_description);
    }
    

    
    





















}