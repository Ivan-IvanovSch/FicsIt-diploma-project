using FicsIt.Models.DTOs;
using FicsIt.Models.Entities;
using FicsIt.Repositories;
using Microsoft.AspNetCore.Identity;

namespace FicsIt.Services
{
    public class AccountService : IAccountService
    {
        private readonly ILogger<AccountService> _logger;
        private readonly InitialContext _context;
        private readonly UserManager<Account> _userManager;

        public AccountService(ILogger<AccountService> logger, InitialContext context, UserManager<Account> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public async Task<IdentityResult> CreateAccountAsync(CreateAccountDTO dto)
        {
            Account createdAccount = new Account()
            {
                Name = dto.Name,
                Email = dto.Email,
                PhoneNumber = dto.PhoneNumber
            };

            return await _userManager.CreateAsync(createdAccount, dto.Password);
        }

        public async Task<IdentityResult> DeleteAccountAsync(string accountId)
        {
            var account = await _userManager.FindByIdAsync(accountId);

            if (account == null)
            {
                return IdentityResult.Failed(
                    new IdentityError
                    {
                        Description = "Account not found."
                    }
                );
            }

            return await _userManager.DeleteAsync(account);
        }
    }
}
