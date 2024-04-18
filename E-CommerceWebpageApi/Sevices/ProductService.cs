using E_CommerceWebpageApi.Models;

namespace E_CommerceWebpageApi.Sevices
{
    public class ProductService
    {
        public List<Product> products = new List<Product>();

        public ProductService()
        {
            products.Add(new Product(1, 199.50, "Medium", "Adidas", "Red", "Shirt"));
            products.Add(new Product(2, 299.50, "Large", "Nike", "Blue", "Shirt"));
            products.Add(new Product(3, 399.50, "Small", "Puma", "Green", "Shirt"));
            
        }

        public bool CreateProduct(Product product)
        {
            products.Add(product);
            return true;
                       
        }

        public bool DeleteProduct(int id)
        {
            
            Product product = products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                products.Remove(product);
                return true;
            }
            return false;
        }

        public List<Product> GetProducts()
        {
            
            return products;
        }

        public void UpdateProduct(Product product)
        {
            
            Product productToUpdate = products.FirstOrDefault(p => p.Id == product.Id);
            if (productToUpdate != null)
            {
                productToUpdate.Size = product.Size;
                productToUpdate.Price = product.Price;
                productToUpdate.Brand = product.Brand;
                productToUpdate.Color = product.Color;
                productToUpdate.Category = product.Category;
            }
        }
    }
}
