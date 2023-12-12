using System;
using System.Collections.Generic;

class Activity
{

    private DateTime date;
    protected int durationMinutes;

    public Activity(DateTime date, int durationMinutes)
    {
        this.date = date;
        this.durationMinutes = durationMinutes;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public string GetSummary()
    {
        return $"{date.ToShortDateString()} {GetType().Name} ({durationMinutes} min): " +
               $"distance {GetDistance()} {GetDistanceUnit()}, " +
               $"speed {GetSpeed()} {GetSpeedUnit()}, " +
               $"pace: {GetPace()} {GetPaceUnit()}";
    }

    private string GetDistanceUnit()
    {
        return "km";
    }

    private string GetSpeedUnit()
    {
        return "kph";
    }

    private string GetPaceUnit()
    {
        return "min per km";
    }









}
