using BankWithdrawalAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace BankWithdrawalAPI.Controllers
{
    [ApiController]
    [Route("bank")]
    public class BankAccountController : ControllerBase
    {
        private readonly IBankAccountService _bankAccountService;

        public BankAccountController(IBankAccountService bankAccountService)
        {
            _bankAccountService = bankAccountService;
        }

        [HttpPost("withdraw")]
        public IActionResult Withdraw([FromQuery] long accountId, [FromQuery] decimal amount)
        {
            var result = _bankAccountService.Withdraw(accountId, amount);

            return Ok(result);
        }
    }
}
