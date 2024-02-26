using LabNetBank.Business.Interfaces.Repositories;
using LabNetBank.Business.Interfaces.Services;
using LabNetBank.Business.Models;
using LabNetBank.Business.Models.Enums;

namespace LabNetBank.Business.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<Account> CreateAccountAsync(AccountType accountType, Guid holderId)
        {
            var account = new Account
            {
                AccountNumber = 1,
                AccountType = accountType,
                Balance = 0,
                Office = 0,
                HolderId = holderId
            };

            return await _accountRepository.Create(account);
        }

        public void Dispose()
        {
           _accountRepository?.Dispose();
        }
    }
}
