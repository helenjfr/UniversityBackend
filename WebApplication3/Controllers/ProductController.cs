﻿using Microsoft.EntityFrameworkCore;
using WebApplication3.Migrations;
using WebApplication5.Models;

namespace WebApplication3.Controllers;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[Controller]")]
public class ProductController: ControllerBase
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
    
}