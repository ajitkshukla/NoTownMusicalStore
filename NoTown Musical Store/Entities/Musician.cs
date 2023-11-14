

using System.ComponentModel.DataAnnotations;

namespace NoTown_Musical_Store.Entities
{
    public class Musician
    {
        [Key]
        public int SSN { get; set; }
        [Required(ErrorMessage = "Musician name is required")]
        [StringLength(50,ErrorMessage = "Name should not exceed 50 characters")]
        [Display(Name = "Name")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [StringLength(10, ErrorMessage = "Phone number should be 10 digits")]
        [Display(Name = " Phone number")]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage ="Address is required.")]
        public Address Address { get; set; }

    }
}
