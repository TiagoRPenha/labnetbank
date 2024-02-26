using LabNetBank.Business.Interfaces.Repositories;
using LabNetBank.Business.Interfaces.Services;
using LabNetBank.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetBank.Business.Services
{
    public class HolderService : IHolderService
    {
        private readonly IHolderRepository _holderRepository;
        private readonly IAccountRepository _accountRepository;

        public HolderService(IHolderRepository holderRepository, IAccountRepository accountRepository)
        {
            _holderRepository = holderRepository;
            _accountRepository = accountRepository;
        }

        public async Task<Holder> CreateHolderAsync(Holder holder)
        {
            return await _holderRepository.Create(holder);
        }

        public async Task<List<Account>> GetAccountsByHolderIdAsync(Guid holderId)
        {
            return await _accountRepository.GetAccountsByHolderId(holderId);
        }
    }
}
