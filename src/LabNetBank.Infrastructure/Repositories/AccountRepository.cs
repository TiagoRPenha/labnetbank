using LabNetBank.Business.Interfaces.Repositories;
using LabNetBank.Business.Models;
using LabNetBank.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetBank.Infrastructure.Repositories
{
    public class AccountRepository : BaseRepository<Account>, IAccountRepository
    {
        public AccountRepository(LabNetBankContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Account>> GetAccountsByHolderId(Guid holderId)
        {
           return _dbSet.Where(p => p.HolderId == holderId).ToList();
        }
    }
}
