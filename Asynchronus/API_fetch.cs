
using System.Threading.Tasks;
public class Product
{
    public string Name { get; set; }
    public Product(string name)
    {
        Name = name;
    }
}

public class API_fetch
{
    public async Task<List<Product>> FetchProductsAsync()
    {
        await Task.Delay(2000);
        return new List<Product>
        {
            new Product("Laptop"),
            new Product("Smartphone"),
            new Product("Tablet")
        };
    }

    public async Task Display()
    {
        List<Product> products = await FetchProductsAsync();
        foreach (var product in products)
        {
            Console.WriteLine(product.Name);
        }
    }
}