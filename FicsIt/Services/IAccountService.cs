using FicsIt.Models.Entities;
using FicsIt.Models.DTOs;
using Microsoft.AspNetCore.Identity;

namespace FicsIt.Services
{
    public interface IAccountService
    {
        Task<IdentityResult> CreateAccountAsync(CreateAccountDTO dto);

        //Task<IdentityResult> UpdateAccountAsync(string accountId, UpdateAccountDTO dto);

        Task<IdentityResult> DeleteAccountAsync(string accountId);
    }
}
