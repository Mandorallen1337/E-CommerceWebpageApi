using E_CommerceWebpageApi.Models;

namespace E_CommerceWebpageApi.Sevices
{
    public class ShoppingCartService
    {
        public List<ShoppingCart> shoppingCarts = new List<ShoppingCart>();

        public ShoppingCartService()
        {
            shoppingCarts.Add(new ShoppingCart(1, 1, 2, 200));
            shoppingCarts.Add(new ShoppingCart(2, 2, 3, 300));
            shoppingCarts.Add(new ShoppingCart(3, 3, 4, 400));
        }
    }
}
