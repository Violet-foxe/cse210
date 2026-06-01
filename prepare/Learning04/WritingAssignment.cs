public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment() : base()
    {
        _title = "Unset";
    }
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}
