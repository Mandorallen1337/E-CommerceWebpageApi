using E_CommerceWebpageApi.Models;
using E_CommerceWebpageApi.Sevices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_CommerceWebpageApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        ShoppingCartService shoppingCartService;

        public ShoppingCartController(ShoppingCartService shoppingCartService)
        {
            this.shoppingCartService = shoppingCartService;
        }
    }
}
