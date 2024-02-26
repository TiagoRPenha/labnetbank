using LabNetBank.Business.Interfaces.Repositories;
using LabNetBank.Business.Models;
using LabNetBank.Business.Models.Enums;
using LabNetBank.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetBank.Infrastructure.Repositories
{
    public class TransferRepository : BaseRepository<Transfer>, ITransferRepository
    {
        public TransferRepository(LabNetBankContext dbContext) : base(dbContext)
        {
        }

        public async Task<Status> Transfer(Transfer accountTransfer)
        {
            throw new NotImplementedException();
        }
    }
}
