using AutoMapper;
using Bakery.Dto.Product;
using Bakery.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Bakery.Controllers
{
    public class ShopController : Controller
    {
        private readonly IProductsRepository _repository;
        private readonly IMapper _mapper;

        public ShopController(IProductsRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetProduct(int productId)
        {
            var product = _repository.GetProduct(productId);

            if (product == null)
            {
                return NotFound();
            }

            return View(_mapper.Map<ProductReadDto>(product));
        }
    }
}
