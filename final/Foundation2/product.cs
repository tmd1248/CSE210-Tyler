using System;

public class Product {
    private string _name;
    private int _product_id;
    private float _price;
    private int _quantity;

    public string Name {
        get {return _name;}
        set {_name = value;}
    }
    public int Product_id {
        get {return _product_id;}
        set {_product_id = value;}
    }
    public float Price {
        get {return _price;}
        set {_price = value;}
    }
    public int Quantity {
        get {return _quantity;}
        set {_quantity = value;}
    }

    public float getTotalPrice() {
        return _price * _quantity;
    }
}