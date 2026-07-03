public class Goal
{
    protected string _title;
    protected string _description;
    protected int _points;

    public Goal()
    {
        _title = "Generic Goal";
        _description = "This is a generic goal worth 10 points";
        _points = 10;
    }
    public Goal(string title, int points, string description)
    {
        _title = title;
        _description = description;
        _points = points;
    }
    public virtual string Display()
    {
        return $"{_title} ({_description})";
    }
    public string DisplayTitle()
    {
        return $"{_title}";
    }
    public virtual string GetSaveString()
    {
        return $"Goal>{_title}|{_description}|{_points}";
    }
    public virtual int GetPoints()
    {
        return _points;
    }
    public virtual int Record()
    {
        return GetPoints();
    }
}