using System;

public class Product
{
    private string name;
    private string productId;
    private decimal price;
    private int quantity;

    public Product(string name, string productId, decimal price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public decimal CalculateTotalPrice()
    {
        return price * quantity;
    }

    public string GetName()
    {
        return name;
    }

    public string GetProductId()
    {
        return productId;
    }
}

public class Order
{
    private Customer customer;
    private List<Product> products;

    public Order(Customer customer, List<Product> products)
    {
        this.customer = customer;
        this.products = products;
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = products.Sum(product => product.CalculateTotalPrice());

        // Agregar costo de envío
        if (customer.IsInUSA())
        {
            totalCost += 5; // Costo de envío dentro de EE. UU.
        }
        else
        {
            totalCost += 35; // Costo de envío fuera de EE. UU.
        }

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";

        foreach (var product in products)
        {
            packingLabel += $"{product.GetName()} - {product.GetProductId()}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = $"Customer: {customer.GetName()}\nAddress: {customer.GetAddress().GetFullAddress()}";

        return shippingLabel;
    }
}