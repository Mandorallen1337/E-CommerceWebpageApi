using E_CommerceWebpageApi.Models;
using E_CommerceWebpageApi.Sevices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_CommerceWebpageApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        OrderService orderService;

        public OrderController(OrderService orderService)
        {
            this.orderService = orderService;
        }
        [HttpGet("getall")]
        public List <Order> GetOrders()
        {
            return orderService.GetOrders();
        }
          

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            Order order = orderService.orders.FirstOrDefault(o => o.Id == id);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
            
        }

        [HttpPost("create")]
        public IActionResult CreateOrder()
        {
            orderService.CreateOrder();
            return Ok();
        }

        [HttpPost("addProductToOrder")]
        public IActionResult AddProductToOrder(int orderId, Product product)
        {
            orderService.AddProductToOrder(orderId, product);
            return Ok();
        }

        [HttpDelete("removeProductFromOrder")]
        public IActionResult RemoveProductFromOrder(int orderId, int productId)
        {
            orderService.RemoveProductFromOrder(orderId, productId);
            return Ok();
        }

        [HttpPut("updateOrderTotalPrice")]
        public IActionResult UpdateOrderTotalPrice(int orderId)
        {
            orderService.UpdateOrderTotalPrice(orderId);
            return Ok();
        }
    }
}
