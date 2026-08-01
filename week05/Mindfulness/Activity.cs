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
    
    public void ShowSpinner(int seconds )
    {
        List <string> spinner = new List<string> {"|" ,"/", "-", "\\" };
        DateTime endtime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endtime)
        {
            foreach (string symbol in spinner)
            Console.Write(symbol);
            Thread.Sleep(250);
            Console.Write("\b \b");

            if (DateTime.Now >= endTime)
            {
                break;
            }
        }
    }
    
    





















}