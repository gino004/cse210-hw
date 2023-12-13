abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();

    public string GetDetailsString()
    {
        return $"{_shortName} - {_description}";
    }

    public override string ToString()
    {
        return $"{_shortName} - {_description} - Progress: {_points}%";
    }

    public void UpdateProgress(int newProgress)
    {
        _points = newProgress;
    }

    public int CalculatePoints()
    {
        return _points * 10;
    }
}