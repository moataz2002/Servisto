using AutoMapper;
using Servisto.Services.ProductAPI.Models;
using Servisto.Services.ProductAPI.Models.Dto;

namespace Servisto.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
