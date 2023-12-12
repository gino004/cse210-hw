using System;

class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points) 
        : base(shortName, description, points)
    {
    
    }

    public override void RecordEvent()
    {
    
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
         return $"{nameof(EternalGoal)}:{_shortName},{_description},{_points}";
    }
}
