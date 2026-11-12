using Microsoft.AspNetCore.Identity;

namespace FicsIt.Models.Entities
{
    public class Account : IdentityUser
    {
        public string Name { get; set; }
    }
}
