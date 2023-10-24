using System;

public abstract class Event {
    protected string _title;
    protected string _description;
    protected DateOnly _date;
    protected TimeOnly _time;
    protected Address address = new Address();
    protected string fullDetails;
    protected string standardDetails;
    protected string shortDescription;

    public string Title {
        get {return _title;}
        set {_title = value;}
    }
    public string Description {
        get {return _description;}
        set {_description = value;}
    }

    public DateOnly Date {
        get {return _date;}
        set {_date = value;}
    }
    public TimeOnly Time {
        get {return _time;}
        set {_time = value;}
    }
        public void setAddress(string street, string city, string state, string country) {
        address.Street = street;
        address.City = city;
        address.State = state;
        address.Country = country;
    }

    public string getStandardDetails() {
        standardDetails = _title + ", " + _description + " " + _time.ToString() + " On " + _date.ToString() + " at " + address.getFullAddress();
        return standardDetails;
    }
    public abstract string getFullDetails();

    public string getShortDescription() {
        shortDescription = _title + ", " + _description + " " + _date.ToString();
        return shortDescription;
    }
}