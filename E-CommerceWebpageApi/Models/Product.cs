namespace E_CommerceWebpageApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string Size { get; set; }
        public string Brand { get; set; }        
        public string Color { get; set; }
        public string Category { get; set; }


        public Product(int id, double price, string size, string brand, string color, string category)
        {
            Id = id;
            Price = price;
            Size = size;
            Brand = brand;
            Color = color;
            Category = category;
        }

        public Product()
        {
        }

    }
}
