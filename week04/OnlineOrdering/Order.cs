using System.Xml.Schema;
using System.Linq;
public class Order
{
    public List<Customer> _customers = new List<Customer>();
    private List<Product> _products = new List<Product>();

    //functions/methods

  

    //Getter and Setter
    public void AddCustomer(Customer newCustomer)
    {
        _customers.Add(newCustomer);
    }

    public void AddProduct(Product newProduct)
    {
        _products.Add(newProduct);
    }

    public void ShippingLabel(string completeAddress)
    {    
        Console.WriteLine("");
        Console.WriteLine(new string('-', 50));
        Console.WriteLine("Shipping Label");
        Console.WriteLine("");
        Console.WriteLine(string.Join(",", _customers.Select(c => c.GetCustomerName())));
        Console.WriteLine(completeAddress);
        Console.WriteLine(new string('-', 50));
        Console.WriteLine("");
    }

    public void PackingLabel()
    {
        Console.WriteLine("");
        Console.WriteLine(new string('-', 50));
        Console.WriteLine("Packing Label");
        Console.WriteLine("");
        foreach (Product product in _products)
        {
            Console.WriteLine($"Product: {product.GetProductName()}, ID#: {product.GetProductID()}");
        }
        Console.WriteLine(new string('-', 50));
        Console.WriteLine("");
    }

    public void Receipt(string completeAddress)
    {
        float totalCost = 0.0f;

        foreach (Product product in _products)
        {
            int itemCount = product.GetProductQuantity();
            float itemPrice = product.GetProductPricePerUnit();
            float totalPrice = itemCount * itemPrice;
            totalCost += totalPrice;
        }

        double roundedTotal = Math.Round(totalCost, 2, MidpointRounding.AwayFromZero);

        int shipping = 0;

        if(completeAddress.Contains("USA"))
        {
            shipping = 5;
        }
        else
        {
            shipping = 35;
        }

        Console.WriteLine("");
        Console.WriteLine(new string('-', 50));
        Console.WriteLine("Bill");
        Console.WriteLine("");
        foreach (Product product in _products)
        {
            Console.WriteLine($"Product: {product.GetProductName()}, Quantity: {product.GetProductQuantity()}, Price: ${product.GetProductPricePerUnit()}");
        }
        Console.WriteLine($"Subtotal: ${roundedTotal}");
        Console.WriteLine($"Freight: ${shipping}");
        Console.WriteLine($"Total: ${totalCost + shipping}");
        Console.WriteLine(new string('-', 50));
        Console.WriteLine("");
    }
}