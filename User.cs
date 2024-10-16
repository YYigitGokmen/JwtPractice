using System.ComponentModel.DataAnnotations;

namespace JwtPractice
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; } // Password will be hashed during registration.
    }
}
