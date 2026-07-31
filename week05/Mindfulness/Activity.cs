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

    public string DisplayStartingMessage() 
    {
        Console.WriteLine(" You are about to take an Activity text so pleaserelax andtake your time to answer this questions. ") 
    }
    public string DisplayEndingMessage()
    {
        Console.WriteLine(" Congratulations,you are doing great.!!")
        console.writeline("")
    }
    





















}