using System;

class Swimming : Activity
{

    private int laps;

    public Swimming(DateTime date, int durationMinutes, int laps)
        : base(date, durationMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000.0; 
    }

    public override double GetSpeed()
    {
        return (GetDistance() / durationMinutes) * 60;
    }

    public override double GetPace()
    {
        return durationMinutes / GetDistance();
    }

}