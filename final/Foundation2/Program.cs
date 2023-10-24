using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order();
        order1.setCustomer("Hank Hankson", "3421 street st.", "Metropolis", "New York", "United States");
        order1.addProduct("Soylent Green", 45433, 21.45f, 2);
        order1.addProduct("Kryptonite", 5, 211144.99f, 1);
        order1.addProduct("dishsoap", 211112, 5, 20);
        Order order2 = new Order();
        order2.setCustomer("Billy the Kid", "I'm not telling", "Still not telling", "bite me", "Nice try, fed");
        order2.addProduct("dynamite", 2299999, 19.11f, 23);
        order2.addProduct("Bullets", 32, .99f, 200);
        order2.addProduct("Train car", 15555895, 2999.99f, 1);
        order2.addProduct("Posse", 0, 0, 15);
        Console.WriteLine(order1.getPackingLabel());
        Console.WriteLine(order1.getShippingLabel());
        Console.WriteLine(order1.getOrderPrice());
        Console.WriteLine(order2.getPackingLabel());
        Console.WriteLine(order2.getShippingLabel());
        Console.WriteLine(order2.getOrderPrice());
    }
}