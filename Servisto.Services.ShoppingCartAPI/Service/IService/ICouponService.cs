using Servisto.Services.ShoppingCartAPI.Models.Dto;

namespace Servisto.Services.ShoppingCartAPI.Service.IService
{
    public interface ICouponService
    {
        Task<CouponDto> GetCoupon(string couponCode);
    }
}
