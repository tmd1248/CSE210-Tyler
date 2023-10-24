using System;

public class Customer {
    private string _name;
    private Address address = new Address();

    public string Name {
        get{ return _name;}
        set { _name = value;}
    }

    public void setAddress(string street, string city, string state, string country) {
        address.Street = street;
        address.City = city;
        address.State = state;
        address.Country = country;
    }

    public Address GetAddress() {
        return address;
    }

    public bool isAmerican() {
        return address.isAmerican();
    }


}