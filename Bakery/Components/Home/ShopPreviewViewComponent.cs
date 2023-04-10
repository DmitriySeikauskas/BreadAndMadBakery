using Bakery.Models.Home;
using Microsoft.AspNetCore.Mvc;
using System.Buffers.Text;
using System.Net.NetworkInformation;

namespace Bakery.Components.Home
{
    public class ShopPreviewViewComponent : ViewComponent
    {
        private readonly IReadOnlyCollection<ProductShoppingPreview> _products;

        public ShopPreviewViewComponent()
        {
            _products = new[]
            {
                new ProductShoppingPreview(1, "product 1", 1_300),
                new ProductShoppingPreview(2, "product 2", 45),
                new ProductShoppingPreview(3, "product 3", 1_650),
            };
        }

        public IViewComponentResult Invoke()
        {
            return View("ShopPreviewView", _products);
        }
    }
}
