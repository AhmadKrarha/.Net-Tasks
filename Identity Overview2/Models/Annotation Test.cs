using System.ComponentModel.DataAnnotations;

namespace Identity_Overview2.Models
{
    public class Annotation_Test
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$", ErrorMessage = "Password must be at least 8 characters long and contain an uppercase letter, a lowercase letter, and a number.")]
        public string Password { get; set; }
    }
}
