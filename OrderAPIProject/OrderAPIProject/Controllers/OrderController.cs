using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderAPIProject.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        
        [HttpGet]
        public IEnumerable<Order> GetOrders()
        {
            return new List<Order>()
            {
             new Order { OrderId=1, ProductName="Product 1", ProductId=1,ProductPrice=100,OrderQty=10,CreatedDate=DateTime.Now },
             new Order { OrderId=2, ProductName="Product 1", ProductId=1,ProductPrice=100,OrderQty=10,CreatedDate=DateTime.Now },
             new Order { OrderId=3, ProductName="Product 3", ProductId=3,ProductPrice=300,OrderQty=30,CreatedDate=DateTime.Now },
             new Order { OrderId=4, ProductName="Product 2", ProductId=2,ProductPrice=200,OrderQty=20,CreatedDate=DateTime.Now },
             new Order { OrderId=5, ProductName="Product 5", ProductId=5,ProductPrice=500,OrderQty=50,CreatedDate=DateTime.Now }            
            };
        }

    }
}
