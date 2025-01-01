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

        /// <summary>
        ///  Get product list.
        /// </summary>
        /// <returns>Return product items</returns>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return productList;
        }

        /// <summary>
        ///  Get specific product item.
        /// </summary>
        /// <param name="id">Product id</param>
        /// <returns>Return specific product.</returns>
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
