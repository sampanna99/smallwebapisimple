using GettingStartedWithAspNetWebApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace GettingStartedWithAspNetWebApi.Controllers
{
    public class ProductController : ApiController
    {
        private List<Product> products = new List<Product>()
        {
            new Product {Id = 1, Name = "T Shirt", Price = 26.5m, Quantity = 5 },
            new Product {Id = 2, Name = "T Shirt 2", Price = 12.5m, Quantity = 9 },
            new Product {Id = 3, Name = "T Shirt", Price = 13.5m, Quantity = 6 },
            new Product {Id = 4, Name = "T Shirt", Price = 14.5m, Quantity = 7 }
        };

        public IEnumerable<Product> Get()
        {
            return products.ToList();

        }

        public IHttpActionResult Get(int id)
        {
            var product = products.Where(a => a.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);

        }

    }
}
