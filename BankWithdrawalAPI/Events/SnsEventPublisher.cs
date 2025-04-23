using System.Text.Json;
using BankWithdrawalAPI.Models;

namespace BankWithdrawalAPI.Events
{
    public class SnsEventPublisher : IEventPublisher
    {
        public void Publish(WithdrawalEvent withdrawalEvent)
        {
            // In a real-real world case, I'd serialise and send this to an SNS topic
            var json = JsonSerializer.Serialize(withdrawalEvent);
            Console.WriteLine($"[SNS PUBLISH] Event sent: {json}"); // This acts as an observability layer

            // Placeholder for calling AWS SNS SDK:
            // snsClient.PublishAsync(new PublishRequest { ... });
        }
    }
}
