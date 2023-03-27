using Bakery.Models.Home;
using Microsoft.AspNetCore.Mvc;

namespace Bakery.Components.Home
{
    public class ShopPreviewViewComponent : ViewComponent
    {
        private readonly IReadOnlyCollection<Product> _products;

        public ShopPreviewViewComponent()
        {
            _products = new[]
            {
                new Product("product 1", 1_300),
                new Product("product 2", 45),
                new Product("product 3", 1_650),
            };
        }

        public IViewComponentResult Invoke()
        {
            return View("ShopPreviewView", _products);
        }
    }
}
