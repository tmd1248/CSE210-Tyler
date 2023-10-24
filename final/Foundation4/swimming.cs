using System;

public class Swimming : Exercise {
    private double _laps;

    public double Laps {
        set {_laps = value;}
    }

    public override double getDistance()
    {
        return _laps * 50 / 1000;
    }
    public override double getSpeed()
    {
        return getDistance() / _time * 60;
    }
    public override double getPace()
    {
        return _time / getDistance();
    }
    public override string getSummary()
    {
        return _date + " Swimming (" + _time + " min)- Distance " + getDistance() + " km, Speed " + getSpeed() + " kph, Pace " + getPace() + " min per km";
    }
}