using Servisto.Services.RewardAPI.Message;

namespace Servisto.Services.RewardAPI.Services
{
    public interface IRewardService
    {
        Task UpdateRewards(RewardsMessage rewardsMessage);
    }
}
