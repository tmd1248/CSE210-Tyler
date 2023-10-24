using System;

public class Stationary_bike : Exercise {
    private double _speed;

    public double Speed {
        set {_speed = value;}
    }

    public override double getDistance()
    {
        return _speed/60 * _time;
    }
    public override double getSpeed()
    {
        return _speed;
    }
    public override double getPace()
    {
        return _time / getDistance();
    }
    public override string getSummary()
    {
        return _date + " stationary bike (" + _time + " min)- Distance " + getDistance() + " km, Speed " + getSpeed() + " kph, Pace " + getPace() + " min per km";
    }
}