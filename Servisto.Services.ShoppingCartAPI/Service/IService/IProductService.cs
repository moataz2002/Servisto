using Servisto.Services.ShoppingCartAPI.Models.Dto;

namespace Servisto.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
