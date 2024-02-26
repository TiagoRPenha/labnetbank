using AutoMapper;
using LabNetBank.API.Models;
using LabNetBank.Business.Interfaces.Services;
using LabNetBank.Business.Models;
using LabNetBank.Business.Models.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;

namespace LabNetBank.API.Controllers
{
    [Route("api/")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private readonly IHolderService _holderService;
        private readonly IMapper _mapper;

        public AccountController(IAccountService accountService, IHolderService holderService, IMapper mapper)
        {
            _accountService = accountService;
            _holderService = holderService;
            _mapper = mapper;
        }

        [HttpPost("account")]
        public async Task<IActionResult> CreateAccountAsync([FromBody] AccountHolderInputModel accountHolderInput)
        {
            var holderInput = _mapper.Map<Holder>(accountHolderInput);

            var holder = await _holderService.CreateHolderAsync(holderInput);

            if (holder != null)
            {
                await _accountService.CreateAccountAsync(accountHolderInput.AccountType, holder.Id);
            }

            return Ok(accountHolderInput);
        }

        [HttpGet("{holderId:guid}")]
        public async Task<IActionResult> GetAccountsByHolderId(Guid holderId)
        {
            return Ok(await _holderService.GetAccountsByHolderIdAsync(holderId));
        }
    }
}
