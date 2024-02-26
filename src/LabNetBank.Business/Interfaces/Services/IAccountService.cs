using LabNetBank.Business.Models;
using LabNetBank.Business.Models.Enums;
namespace LabNetBank.Business.Interfaces.Services
{
    public interface IAccountService : IDisposable
    {
        Task<Account> CreateAccountAsync(AccountType accountType, Guid holderId);
    }
}
