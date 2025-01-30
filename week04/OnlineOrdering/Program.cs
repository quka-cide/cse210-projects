using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "L123", 1000, 1));
        order1.AddProduct(new Product("Mouse", "M456", 25, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total cost: {order1.GetTotalCost():F2}\n");

        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Alice Smith", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Keyboard", "K789", 50, 1));
        order2.AddProduct(new Product("Monitor", "M101", 300, 1));
        order2.AddProduct(new Product("USB Drive", "U202", 15, 3));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}