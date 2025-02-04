using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("8013 Bay Street","New York","NY 10040","USA");
        Address address2 = new Address("47th Avenue","Elsa","Yukon","Canada");

        Customer customer1 = new Customer("John Roblox", address1);
        Customer customer2 = new Customer("John Minecraft", address2);

        Product product1 = new Product ("Dirt Block", "P023", 99.9m, 1);
        Product product2 = new Product ("Ice Dagger","P241", 420.99m, 2);
        Product product3 = new Product ("Diamonds","P251", 500.9m, 1);
        Product product4 = new Product ("Link Sword","P001", 34.99m, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product1);
        order2.AddProduct(product2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}\n");


    }
}