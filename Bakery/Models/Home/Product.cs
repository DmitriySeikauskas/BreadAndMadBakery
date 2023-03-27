namespace Bakery.Models.Home
{
    public class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; }
        public double Price { get; }
    }
}