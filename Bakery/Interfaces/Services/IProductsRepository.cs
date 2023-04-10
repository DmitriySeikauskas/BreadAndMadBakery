using Bakery.Data.Product;

namespace Bakery.Interfaces.Services
{
    public interface IProductsRepository
    {
        IReadOnlyCollection<Product> GetAllProducts();
        Product GetProduct(int productId);
    }
}
