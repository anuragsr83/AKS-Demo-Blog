using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductAPIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {        
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return new List<Product>()
            {
            new Product {ProductId=1, Name="Product 1",Price=100,CreatedDate=DateTime.Now },
            new Product {ProductId=2, Name="Product 2",Price=200,CreatedDate=DateTime.Now },
            new Product {ProductId=3, Name="Product 3",Price=300,CreatedDate=DateTime.Now },
            new Product {ProductId=4, Name="Product 4",Price=400,CreatedDate=DateTime.Now },
            new Product {ProductId=5, Name="Product 5",Price=500,CreatedDate=DateTime.Now },
            };
        }
    }
}
