using System.ComponentModel.DataAnnotations;

namespace NoTown_Musical_Store.Entities
{
    public class Album
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Title;
        [Required]
        public DateTime CopyrightDate { get; set; }
        [Required]
        public int speed;

    }
}
