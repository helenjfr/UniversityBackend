using Microsoft.EntityFrameworkCore;
using WebApplication3.Migrations;
using WebApplication5.Models;
using Car = WebApplication5.Models.Car;

namespace WebApplication3.Controllers;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[Controller]")]
public class ProductController : ControllerBase
{
    public databaseContext context;

    public ProductController(databaseContext contextCopy)
    {
        context = contextCopy;
    }

    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetAllProducts()
    {
        var ProductsFromDatabase = await context.Products.ToListAsync();
        return ProductsFromDatabase;
    }

    // [HttpGet("GetSpecificProduct")]
    // {

    // }
    [HttpPost]
    public async Task<ActionResult<Product>> creatNewProduct(Product NewProduct)
    {
        context.Products.Add(NewProduct);
        await context.SaveChangesAsync();
        return Ok(NewProduct);
    }

    [HttpGet("{ProductId}")]
    public async Task<ActionResult<Product>> GetSpecificProduct(int ProductId)
    {
        // var ProductsFromDatabase = await context.Products.ToListAsync();
        // foreach (var product in ProductsFromDatabase)
        // {
        // if (product.id == ProductId)
        // {
        // return Ok(product);
        // }
        var FoundProduct = await context.Products.FirstAsync(product => (product.id == ProductId));
        if (FoundProduct == null)
        {
            return NotFound();
        }
        return Ok(FoundProduct);
    }

    [HttpDelete("{ProductId}")]
    public async Task<ActionResult> DeleteProduct(int ProductId)
    {
        var FoundProduct = await context.Products.FirstAsync(product => (product.id == ProductId));
        if (FoundProduct == null)
        {
            return NotFound("Existential crisis");
        }

        context.Products.Remove(FoundProduct);
        await context.SaveChangesAsync();
        return Ok();
    }

}