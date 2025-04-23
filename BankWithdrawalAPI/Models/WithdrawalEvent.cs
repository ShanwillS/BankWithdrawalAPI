namespace BankWithdrawalAPI.Models
{
    public class WithdrawalEvent
    {
        public WithdrawalEvent(decimal amount, long accountId, string status)
        {
            Amount = amount;
            AccountId = accountId;
            Status = status;
        }

        public decimal Amount { get; set; } // BigDecimal equivalent 
        public long AccountId { get; set; }
        public string Status { get; set; }
    }
}
