using AutoMapper;
using Bakery.Data.Product;
using Bakery.Dto.Product;
using Bakery.Models.Home;

namespace Bakery.Profiles
{
    public class ProductsProfile : Profile
    {
        public ProductsProfile()
        {
            CreateMap<Product, ProductShoppingPreview>()
                .ConstructUsing(source => new ProductShoppingPreview(source.Id, source.Name, source.Price, source.Image));
                //.ForMember(destination => destination.Id, mapperOptions => mapperOptions.MapFrom(product => product.Id))
                //.ForMember(destination => destination.Name, mapperOptions => mapperOptions.MapFrom(product => product.Name))
                //.ForMember(destination => destination.Price, mapperOptions => mapperOptions.MapFrom(product => product.Price))
                //.ForMember(destination => destination.Image, mapperOptions => mapperOptions.MapFrom(product => product.Price));

            
        }
    }
}
