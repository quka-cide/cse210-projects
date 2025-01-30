using System.Dynamic;
using System.Net.Sockets;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }
        totalCost += _customer.IsInUSA() ? 5 : 35;
        return totalCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder("Packing label:\n");
        foreach (Product product in _products)
        {
            string productName = product.GetName();
            string productId = product.GetProductId();
            packingLabel.AppendLine($"Product name: {productName} (ID: {productId})");
        }
        return packingLabel.ToString();
    }
    
    public string GetShippingLabel()
    {
        string name = _customer.GetName();
        Address address = _customer.GetAddress();
        return $"Shipping Label:\n{name}\n{address.DisplayAddress()}";
    }
}