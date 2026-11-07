using Microsoft.EntityFrameworkCore;
using FicsIt.Models.Entities;

namespace FicsIt.Repositories
{
    public class InitialContext : DbContext
    {
        public InitialContext(DbContextOptions<InitialContext> options)
        : base(options)
        {
        }

        public DbSet<Account> Accounts => Set<Account>();
    }
}
