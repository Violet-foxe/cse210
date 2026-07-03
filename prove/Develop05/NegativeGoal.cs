public class NegativeGoal : Goal
{
    private int _streak;

    public NegativeGoal(string title, int points, int streak, string description) : base(title, points, description)
    {
        _points = -Math.Abs(points); // just to make sure the points are negative
        _streak = streak;
    }
    public NegativeGoal(string title, int points, string description) : base(title, points, description)
    {
        _points = -Math.Abs(points); // just to make sure the points are negative
        _streak = 0;
    }
    public override string Display()
    {
        // make a string
        string displayString = $"[-] {_title} ({_description}) -- streak: {_streak}";
        return displayString;
    }
    public override string GetSaveString()
    {
        string saveString = $"NGoal>{_title}|{_description}|{_points}|{_streak}";
        return saveString;
    }
    public override int Record()
    {
        _streak += 1;
        return GetPoints();
    }
}