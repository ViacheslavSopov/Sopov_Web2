using System.ComponentModel.DataAnnotations;

namespace Lab4.Models
{
    public class ResetModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Message { get; set; }

        public string Code { get; set; }
    }
}
