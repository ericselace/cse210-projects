using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create addresses
        Address usaAddress = new Address("123 Main St", "New York", "NY", "USA");
        Address canadaAddress = new Address("456 Maple Rd", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("Alice Johnson", usaAddress);
        Customer customer2 = new Customer("Bob Smith", canadaAddress);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P001", 1200.00, 1));
        order1.AddProduct(new Product("Mouse", "P002", 25.00, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Headphones", "P003", 80.00, 1));
        order2.AddProduct(new Product("Keyboard", "P004", 45.00, 1));
        order2.AddProduct(new Product("Monitor", "P005", 200.00, 2));

        // Display results
        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.GetTotalPrice():0.00}");
            Console.WriteLine(new string('-', 40));
        }
    }
}
