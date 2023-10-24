using System;
using System.Runtime.CompilerServices;

public class Order {
    private List<Product> products = new List<Product>();
    private Customer customer = new Customer();
    private float total;
    private string packingLabel;
    private string ShippingLabel;

    public void setCustomer(string name, string street, string city, string state, string country) {
        customer.Name = name;
        customer.setAddress(street, city, state, country);
    }
    public void addProduct(string name, int product_id, float price, int quantity) {
        Product product = new Product {
            Name = name, 
            Product_id = product_id,
            Price = price,
            Quantity = quantity
        };
        products.Add(product);
    }
    public float getOrderPrice() {
        total = 0.00f;
        foreach (Product product in products) {
            total += product.getTotalPrice();
        }
        if(customer.isAmerican()) {
            total += 5;
        } else {
            total += 35;
        }
        total = Convert.ToSingle(Math.Round(total*100)/100);
        return total;
    }
    public string getPackingLabel() {
        packingLabel = "";
        foreach(Product product in products) {
            packingLabel += product.Name + ", " + product.Product_id + "\n";
        }
        return packingLabel;
    }

    public string getShippingLabel() {
        Address address = customer.GetAddress();
        ShippingLabel = "";
        ShippingLabel += customer.Name + " ";
        ShippingLabel += address.getFullAddress();
        return ShippingLabel;
    }

}