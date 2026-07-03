public class EternalGoal : Goal
{
    private int _streak;

    public EternalGoal(string title, int points, string description) : base(title, points, description)
    {
        _streak = 0;
    }
    public EternalGoal(string title, int points, int streak, string description) : base(title, points, description)
    {
        _streak = streak;
    }
    public override string Display()
    {
        // make a string
        string displayString = $"[-] {_title} ({_description}) -- {_streak}";
        return displayString;
    }
    public override string GetSaveString()
    {
        string saveString = $"EGoal>{_title}|{_description}|{_points}|{_streak}";
        return saveString;
    }
    public override int Record()
    {
		_streak += 1;
        return GetPoints();
    }
}