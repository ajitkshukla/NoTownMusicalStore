using System.ComponentModel.DataAnnotations;

namespace NoTown_Musical_Store.Entities
{
    public class Address
    {
        [Required]
        public string? Street { get; set; }
        [Required]
        public string? City { get; set; }
        [Required]
        public string? State { get; set; }
        [Required]
        public string? ZipCode { get; set; }
        [Required]
        public string? Country { get; set; }
    }
}
