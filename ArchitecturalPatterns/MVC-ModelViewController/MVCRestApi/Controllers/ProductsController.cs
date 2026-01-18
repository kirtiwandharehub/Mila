using MVCRestApi.Models;
using MVCRestApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;

namespace MVCRestApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly ProductStore productStore;

    public ProductsController(ProductStore productStore)
    {
        this.productStore = productStore;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(productStore.GetAll());
    }

    [HttpGet("{id:int}")]
    public IActionResult GetById(int id)
    {
        Product product = productStore.GetById(id);
        return product is null ? NotFound() : Ok(product);
    }

    [HttpPost]
    public IActionResult Create([FromBody] CreateProductRequest request)
    {
        Product product = productStore.Add(request.Name, request.Price);
        return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        return productStore.Delete(id) ? NoContent() : NotFound();
    }
}

public record CreateProductRequest(string Name, decimal Price);