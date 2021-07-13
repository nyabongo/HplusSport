using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HPlusSport.API.Classes;
using HPlusSport.API.Models;
using JsonApiDotNetCore.Configuration;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HPlusSport.API.Controllers
{
    public class ProductsController : JsonApiController<Product>
    {
        private readonly IResourceService<Product> ResourceService;

        public ProductsController(IJsonApiOptions options, ILoggerFactory loggerFactory,
        IResourceService<Product> resourceService)
        : base(options, loggerFactory, resourceService)
        {
            this.ResourceService = resourceService;
        }

        // [HttpGet]
        // public async Task<IActionResult> GetAllProducts([FromQuery] QueryParameters queryParameters)
        // {
        //     IQueryable<Product> products = _context.Products;
        //     products = products
        //         .Skip(queryParameters.Size * (queryParameters.Page - 1))
        //         .Take(queryParameters.Size);
        //     // Product[] products = await _context.Products.ToArrayAsync();
        //     return Ok(await products.ToArrayAsync());
        // }

        // [HttpGet("{id}")]
        // public async Task<IActionResult> GetProduct(int id)
        // {
        //     var product = await _context.Products.FindAsync(id);
        //     return product == null ? NotFound() : Ok(product);
        // }
    }
}