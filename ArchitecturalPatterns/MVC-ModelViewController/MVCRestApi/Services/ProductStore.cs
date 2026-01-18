using System.Collections.Concurrent;
using MVCRestApi.Models;

namespace MVCRestApi.Services;

public class ProductStore
{
    private readonly ConcurrentDictionary<int, Product> products;
    private int idCounter;

    public ProductStore()
    {
        products = new();
        idCounter = 0;
    }

    public Product GetById(int id) => products.TryGetValue(id, out Product product) ? product : null;

    public IEnumerable<Product> GetAll() => products.Values;

    public Product Add(string name, decimal price)
    {
        int id = Interlocked.Increment(ref idCounter);
        Product product = new Product() {Id = id, Name = name, Price = price};
        products[id] = product;

        return product;
    }

    public bool Delete(int id)
    {
        return products.TryRemove(id, out _);
    }
}