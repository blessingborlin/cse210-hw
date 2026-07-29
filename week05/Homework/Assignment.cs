public class Assignment
{
    private string _studentName;
    private string _topic;
    
    public Assignment(string studentName, string topic )
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        string text = $"{_studentName}";
        return text;
    } 
    public string Getsummary()
    {
        string topic = $"{_topic}";
        return topic;
    }
           
}