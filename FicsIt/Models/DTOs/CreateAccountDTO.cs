using System.ComponentModel.DataAnnotations;

namespace FicsIt.Models.DTOs
{
    public class CreateAccountDTO
    {
        [Required]
        [StringLength(50), MinLength(4)]
        public string UserName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Required]
        public string PhoneNumber { get; set; } = string.Empty;

        public string? Name { get; set; }
    }
}
