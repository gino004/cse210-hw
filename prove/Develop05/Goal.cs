using System;
abstract class Goal
{
    protected string _shortName;
    private string _description;
    private int _points;
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public void RecordEvent()
    {

    }
    public bool isComplete()
    {
        return true;
    }
    public string GetDetailsString()
    {
         return $"{(_isComplete ? "[X]" : "[ ]")} {_shortName}: {_description}";
    }
    public string GetStringRepresentation()
    {
        return "";
    }

}