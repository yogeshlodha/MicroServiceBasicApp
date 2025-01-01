using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductService.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private string[] productList;
        public ProductController()
        {
            this.productList = ["Product 1", "Product 2", "Product 3", "Product 4", "Product 5"];        
        }

        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return productList;
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
            if (productList.Where(a => a == id).Any())
            {
                return id;
            }

            return string.Empty;
        }
    }
}
