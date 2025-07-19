using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public IEnumerable<Product> Get()
    {
        return new List<Product>
        {
            new Product { Id = 1, Name = "Tablet", Price = 15000 },
            new Product { Id = 2, Name = "Monitor", Price = 12000 }
        };
    }
}
