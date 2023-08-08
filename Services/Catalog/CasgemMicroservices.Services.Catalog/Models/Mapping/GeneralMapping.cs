using AutoMapper;
using CasgemMicroservices.Services.Catalog.Dtos.CategoryDtos;
using CasgemMicroservices.Services.Catalog.Dtos.ProductDtos;

namespace CasgemMicroservices.Services.Catalog.Models.Mapping
{
    public class GeneralMapping : Profile
    {
        protected GeneralMapping()
        {
            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();

            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();

            
        }
    }
}
