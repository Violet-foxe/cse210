public class ChecklistGoal : Goal
{
    private bool _completed;
    private int _streak;
    private int _target;
    private int _bonusPoints;

    public ChecklistGoal(string title, int points, int target, int bonusPoints, string description) : base(title, points, description)
    {
        _completed = false;
        _streak = 0;
        _target = target;
        _bonusPoints = bonusPoints;
    }
    public ChecklistGoal(string title, int points, int target, int bonusPoints, int streak, string description) : base(title, points, description)
    {
        _streak = streak;
        _target = target;
        _bonusPoints = bonusPoints;
        _completed = getCompleted();
    }
    public bool getCompleted()
    {
        if (_streak >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void changeCompleted()
    {
        _completed = getCompleted();
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
        string displayString = $"{completeString} {_title} ({_description}) -- {_streak}/{_target}";
        return displayString;
    }
    public override string GetSaveString()
    {
        string saveString = $"CGoal>{_title}|{_description}|{_points}|{_bonusPoints}|{_target}|{_streak}";
        return saveString;
    }
    public int GetBonusPoints()
    {
        return _bonusPoints;
    }
    public override int Record()
    {
        _streak += 1;
        if (getCompleted() && _streak == _target)
        {
            // if its completed, reward the extra points.
            changeCompleted();
            return GetBonusPoints() + GetPoints();
        }
        else
        {
            return GetPoints();
        }
    }
}