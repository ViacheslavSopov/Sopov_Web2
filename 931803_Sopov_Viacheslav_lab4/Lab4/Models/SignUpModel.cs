using System.ComponentModel.DataAnnotations;

namespace Lab4.Models
{
    public class SignUpModel
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public string Day { get; set; }

        public string Month { get; set; }

        public string Year { get; set; }

        public string Gender { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string Confirm { get; set; }
    }
}
