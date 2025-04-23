using BankWithdrawalAPI.Models;

namespace BankWithdrawalAPI.Events
{
    public interface IEventPublisher
    {
        void Publish(WithdrawalEvent withdrawalEvent);
    }
}
