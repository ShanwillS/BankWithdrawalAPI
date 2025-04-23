using BankWithdrawalAPI.Events;
using BankWithdrawalAPI.Repositories;
using BankWithdrawalAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Add dependency injections here later (e.g. services, repositories, etc.)
builder.Services.AddSingleton<IAccountRepository, AccountRepository>();
builder.Services.AddSingleton<IEventPublisher, SnsEventPublisher>();
builder.Services.AddScoped<IBankAccountService, BankAccountService>();

var app = builder.Build();

app.UseAuthorization();
app.MapControllers();
app.Run();
