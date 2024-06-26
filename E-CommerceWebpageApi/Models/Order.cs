﻿namespace E_CommerceWebpageApi.Models
{
    public class Order
    {
        public int Id { get; set; }
        public double TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public List<Product> Products { get; set; }

        public Order()
        {

        }

        public Order(int id, double totalPrice, DateTime orderDate)
        {
            this.Id = id;
            this.TotalPrice = totalPrice;
            this.OrderDate = orderDate;            
        }

    }
}
