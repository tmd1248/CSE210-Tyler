using System;

public class Lecture : Event {
    private string _speaker;
    private int _capacity;
    public string Speaker {
        get {return _speaker;}
        set {_speaker = value;}
    }
    public int Capacity {
        get {return _capacity;}
        set {_capacity = value;}
    }

    public override string getFullDetails()
    {
        fullDetails = _title + ", a lecture put on by "+ _speaker + ". Where they will be discussing " + _description + " Only the first " + _capacity + " People to sign up will make it in. Join us at " + _time.ToString() + " On " + _date.ToString() + " located at " + address.getFullAddress();
        return fullDetails;
    }
}