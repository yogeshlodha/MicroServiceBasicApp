using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private string[] orderList;
        public OrderController()
        {
            this.orderList = [ "Order 1", "Order 2", "Order 3", "Order 4", "Order 5" ];
        }
       
        /// <summary>
        /// Get order list.
        /// </summary>
        /// <returns>Return order list.</returns>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return this.orderList;
        }

       /// <summary>
       ///  Get specifc order detail.
       /// </summary>
       /// <param name="id">Order Id</param>
       /// <returns>Return specific order item details.</returns>
        [HttpGet("{id}")]
        public string Get(string id)
        {
            if(orderList.Where(a=>a == id).Any())
            {
                return id;
            }
         
            return string.Empty;
        }
    }
}
