public class Assignment
{
    protected string _studentName;
    protected string _topic;

    public Assignment()
    {
        _studentName = "Anon";
        _topic = "Blank";
    }
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    public string GetStudentName()
    {
        return _studentName;
    }
    public string GetTopic()
    {
        return _topic;
    }
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}