using LabNetBank.Business.Models;

namespace LabNetBank.Business.Interfaces.Repositories
{
    public interface IAccountRepository : IBaseRepository<Account>
    {
        Task<List<Account>> GetAccountsByHolderId(Guid holderId);
    }
}
