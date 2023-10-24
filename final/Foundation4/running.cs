using System;

public class Running : Exercise {
    private double _distance;

    public double Distance {
        set {_distance = value;}
    }

    public override double getDistance()
    {
        return _distance;
    }
    public override double getSpeed()
    {
        return _distance / _time * 60;
    }
    public override double getPace()
    {
        return _time / _distance;
    }
    public override string getSummary()
    {
        return _date + " Running (" + _time + " min)- Distance " + _distance + " km, Speed " + getSpeed() + " kph, Pace " + getPace() + " min per km";
    }
}