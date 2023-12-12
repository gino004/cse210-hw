using System;

class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, int points) 
        : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    
    public override void RecordEvent()
    {
         _amountCompleted++;
        if (_amountCompleted == _target)
        {
            _points += _bonus;
        }
    }
    public override bool IsComplete()
    {
        return _amountCompleted == _target;
    }
    public override string GetDetailsString()
    {
        return $"{(_isComplete ? "[X]" : "[ ]")} {_shortName}: {_description} (Completed {_amountCompleted}/{_target} times)";
    }

    public override string GetStringRepresentation()
    {
         return $"{nameof(ChecklistGoal)}:{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }
}