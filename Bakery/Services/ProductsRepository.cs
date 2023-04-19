using AutoMapper;
using Bakery.Data.Product;
using Bakery.Interfaces.Services;
using Bakery.Models.Home;

namespace Bakery.Services
{
    public class ProductsRepository : IProductsRepository
    {
        private IReadOnlyCollection<Product> _products;

        public ProductsRepository()
        {
            _products = new List<Product>()
            {
                CreateProduct(1, "product 1", 1_300, "product 1 description"),
                CreateProduct(2, "product 2", 45, "product 2 description"),
                CreateProduct(3, "product 3", 1_650, "product 3 description"),
            };

            Product CreateProduct(int id, string name, double price, string description)
            {
                return new Product
                {
                    Id = id,
                    Name = name,
                    Price = price,
                    Description = description,
                };
            }
        }

        public IReadOnlyCollection<Product> GetAllProducts()
        {
            return _products;
        }

        public Product GetProduct(int productId)
        {
            return _products.FirstOrDefault(p => p.Id == productId);
        }
    }
}
