using System;

public abstract class Exercise {
    protected DateOnly _date;
    protected double _time;
    public DateOnly Date {
        get {return _date;}
        set {_date = value;}
    }
    public double Time {
        get {return _time;}
        set {_time = value;}
    }
    public abstract double getDistance();
    public abstract double getSpeed();
    public abstract double getPace();
    public abstract string getSummary();
}