class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) 
        : base(shortName, description, points)
    {
    }

    public override void RecordEvent()
    {
        // Specific implementation for EternalGoal
    }

    public override bool IsComplete()
    {
        return false; // Actual implementation may vary
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}";
    }
}
