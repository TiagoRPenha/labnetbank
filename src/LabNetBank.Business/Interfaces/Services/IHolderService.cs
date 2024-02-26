using LabNetBank.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetBank.Business.Interfaces.Services
{
    public interface IHolderService
    {
        Task<Holder> CreateHolderAsync(Holder holder);
        Task<List<Account>> GetAccountsByHolderIdAsync(Guid holderId);
    }
}
