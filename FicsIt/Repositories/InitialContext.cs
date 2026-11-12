using Microsoft.EntityFrameworkCore;
using FicsIt.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace FicsIt.Repositories
{
    public class InitialContext : IdentityDbContext<IdentityUser>
    {
        public InitialContext(DbContextOptions<InitialContext> options)
        : base(options)
        {
        }

        public DbSet<Account> Accounts => Set<Account>();
    }
}
