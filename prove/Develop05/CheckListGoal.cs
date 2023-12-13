class ChecklistGoal : Goal
{
    protected int _amountCompleted;
    protected int _target;
    protected int _bonus;

    public ChecklistGoal(string shortName, string description, int points) 
        : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = 0; // Adjust as needed
        _bonus = 0; // Adjust as needed
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    // public override string GetDetailsString()
    // {
    //     return $"{base.GetDetailsString()} - Completed {_amountCompleted} times";
    // }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
    }
}