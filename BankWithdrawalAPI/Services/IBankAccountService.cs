namespace BankWithdrawalAPI.Services
{
    public interface IBankAccountService
    {
        string Withdraw(long accountId, decimal amount);
    }
}