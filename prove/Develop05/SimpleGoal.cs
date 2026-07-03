public class SimpleGoal : Goal
{
    private bool _completed;


    public SimpleGoal(string title, int points, bool completed, string description) : base(title, points, description)
    {
        _completed = completed;
    }
    public SimpleGoal(string title, int points, string description) : base(title, points, description)
    {
        _completed = false;
    }
    public override string Display()
    {
        // make _completed visible
        string completeString = "[ ]";
        if (_completed)
        {
            completeString = "[X]";
        }

        // make a string
        string displayString = $"{completeString} {_title} ({_description})";
        return displayString;
    }
    public override string GetSaveString()
    {
        string saveString = $"SGoal>{_title}|{_description}|{_points}|{_completed}";
        return saveString;
    }
    public void Complete()
    {
        _completed = true;
    }
    public override int Record()
    {
		Complete();
        return GetPoints();
    }
}