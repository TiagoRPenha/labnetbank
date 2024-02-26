using LabNetBank.Business.Models;
using LabNetBank.Business.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetBank.Business.Interfaces.Repositories
{
    public interface ITransferRepository : IBaseRepository<Transfer>
    {
        Task<Status> Transfer(Transfer accountTransfer);
    }
}
