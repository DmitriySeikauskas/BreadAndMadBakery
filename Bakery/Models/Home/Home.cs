namespace Bakery.Models.Home
{
    public class Home
    {
        public Home(IReadOnlyCollection<Product> products)
        {
            Products = products;
        }

        public IReadOnlyCollection<Product> Products { get; }
    }
}