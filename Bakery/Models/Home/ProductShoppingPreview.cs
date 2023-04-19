namespace Bakery.Models.Home
{
    public class ProductShoppingPreview
    {
        public ProductShoppingPreview(int id, string name, double price, string image)
        {
            Id = id;
            Image = image;
            Name = name;
            Price = price;
        }

        public int Id { get; }
        public string Image { get; }
        public string Name { get; }
        public double Price { get; }
        
    }
}