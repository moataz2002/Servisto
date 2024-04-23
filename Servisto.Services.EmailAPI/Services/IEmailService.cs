using Servisto.Services.EmailAPI.Message;
using Servisto.Services.EmailAPI.Models.Dto;

namespace Servisto.Services.EmailAPI.Services
{
    public interface IEmailService
    {
        Task EmailCartAndLog(CartDto cartDto);
        Task RegisterUserEmailAndLog(string email);
        Task LogOrderPlaced(RewardsMessage rewardsDto);
    }
}
