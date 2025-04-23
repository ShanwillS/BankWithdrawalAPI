using BankWithdrawalAPI.Models;

namespace BankWithdrawalAPI.Repositories
{
    public interface IAccountRepository
    {
        Account GetAccountById(long accountId);
        bool UpdateBalance(long accountId, decimal newBalance);
    }
}
