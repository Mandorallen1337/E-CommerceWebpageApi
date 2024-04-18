using E_CommerceWebpageApi.Models;

namespace E_CommerceWebpageApi.Sevices
{
    public class OrderService
    {
        public List<Order> orders = new List<Order>();

        public OrderService() 
        {
            orders.Add(new Order(1, 100, DateTime.Now));
            orders.Add(new Order(2, 200, DateTime.Now));
            orders.Add(new Order(3, 300, DateTime.Now));
        }
        public void CreateOrder()
        {
            orders.Add(new Order(orders.Count + 1, 0, DateTime.Now));

        }

        public void AddProductToOrder(int orderId, Product product)
        {
            Order order = orders.FirstOrDefault(o => o.Id == orderId);
            order.Products.Add(product);
        }

        public void RemoveProductFromOrder(int orderId, int productId)
        {
            Order order = orders.FirstOrDefault(o => o.Id == orderId);
            Product product = order.Products.FirstOrDefault(p => p.Id == productId);
            order.Products.Remove(product);
        }

        public void UpdateOrderTotalPrice(int orderId)
        {
            Order order = orders.FirstOrDefault(o => o.Id == orderId);
            order.TotalPrice = order.Products.Sum(p => p.Price);
        }

        public List<Order> GetOrders()
        {
            return orders;            
        }
    }
}
