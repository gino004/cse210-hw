using System;

class Program
{
    static void Main(string[] args)
    {
        
        Address address1 = new Address("123 Main St", "Cityville", "CA", "USA");
        Address address2 = new Address("456 Oak St", "Townsville", "NY", "Canada");

        
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        
        Product product1 = new Product("Widget", "W123", 10.99m, 2);
        Product product2 = new Product("Gadget", "G456", 19.99m, 1);
        Product product3 = new Product("Thingamajig", "T789", 5.49m, 3);

        
        Order order1 = new Order(customer1, new List<Product> { product1, product2 });
        Order order2 = new Order(customer2, new List<Product> { product3 });

        
        Console.WriteLine("Order 1:");
        Console.WriteLine($"Packing Label:\n{order1.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order1.GetShippingLabel()}");
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine($"Packing Label:\n{order2.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order2.GetShippingLabel()}");
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}");
    }
    
    }
