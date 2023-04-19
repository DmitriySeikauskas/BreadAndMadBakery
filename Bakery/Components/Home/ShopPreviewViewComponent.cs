using AutoMapper;
using Bakery.Interfaces.Services;
using Bakery.Models.Home;
using Microsoft.AspNetCore.Mvc;

namespace Bakery.Components.Home
{
    public class ShopPreviewViewComponent : ViewComponent
    {
        private readonly IReadOnlyCollection<ProductShoppingPreview> _products;

        public ShopPreviewViewComponent(IProductsRepository repository, IMapper mapper)
        {
            _products = mapper.Map<IReadOnlyCollection<ProductShoppingPreview>>(repository.GetAllProducts().Take(3));
        }

        public IViewComponentResult Invoke()
        {
            return View("ShopPreviewView", _products);
        }
    }
}
