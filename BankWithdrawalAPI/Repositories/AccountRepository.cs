using BankWithdrawalAPI.Models;

namespace BankWithdrawalAPI.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        // Simulate a data store
        private static readonly Dictionary<long, Account> _accounts = new()
        {
            { 1, new Account { Id = 1, Balance = 1000.00m } },
            { 2, new Account { Id = 2, Balance = 500.00m } },
        };

        public Account GetAccountById(long accountId)
        {
            _accounts.TryGetValue(accountId, out var account);
            return account;
        }

        public bool UpdateBalance(long accountId, decimal newBalance)
        {
            if (_accounts.TryGetValue(accountId, out var account))
            {
                account.Balance = newBalance;
                return true;
            }

            return false;
        }
    }
}
