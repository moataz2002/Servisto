
using Servisto.Services.OrderAPI.Models.Dto;

namespace Servisto.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
