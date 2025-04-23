using BankWithdrawalAPI.Events;
using BankWithdrawalAPI.Models;
using BankWithdrawalAPI.Repositories;

namespace BankWithdrawalAPI.Services
{
    public class BankAccountService : IBankAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventPublisher _eventPublisher;

        public BankAccountService(IAccountRepository accountRepository, IEventPublisher eventPublisher)
        {
            _accountRepository = accountRepository;
            _eventPublisher = eventPublisher;
        }

        public string Withdraw(long accountId, decimal amount)
        {
            var account = _accountRepository.GetAccountById(accountId);

            if (account == null)
            {
                return "Account not found";
            }

            if (account.Balance < amount)
            { 
                return "Insuffcient funds for withdrawal"; 
            }

            var newBalance = account.Balance - amount;
            var updateSuccess = _accountRepository.UpdateBalance(accountId, newBalance);

            var status = updateSuccess ? "SUCCESSFUL" : "FAILED";
            var withdrawalEvent = new WithdrawalEvent(amount, accountId, status);

            _eventPublisher.Publish(withdrawalEvent);

            return updateSuccess ? "Withdrawal successful" : "Withdrawal failed";
        }
    }
}
