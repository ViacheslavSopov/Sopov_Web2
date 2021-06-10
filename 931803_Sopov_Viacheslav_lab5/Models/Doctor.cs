using System.ComponentModel.DataAnnotations;

namespace Lab5.Models
{
    public class Doctor

    {
        [Key]
        public int _id { get; set; }
        
        [Required]
        public string Name { get; set; }
        [Required]
        public string Speciality { get; set; }
    }
}