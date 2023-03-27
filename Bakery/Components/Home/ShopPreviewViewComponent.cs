using Bakery.Models.Home;
using Microsoft.AspNetCore.Mvc;
using System.Buffers.Text;
using System.Net.NetworkInformation;

namespace Bakery.Components.Home
{
    public class ShopPreviewViewComponent : ViewComponent
    {
        private readonly IReadOnlyCollection<Product> _products;

        public ShopPreviewViewComponent()
        {
            _products = new[]
            {
                new Product(1, "product 1", 1_300),
                new Product(2, "product 2", 45),
                new Product(3, "product 3", 1_650),
            };
        }

        public IViewComponentResult Invoke()
        {
            return View("ShopPreviewView", _products);
        }
    }
}
