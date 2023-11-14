using System.ComponentModel.DataAnnotations;

namespace NoTown_Musical_Store.Entities
{
    public class Instruments
    {
        [Key] 
        public int InstrumentID { get; set; }
        [Required(ErrorMessage = "Instrument name is required")]
        [StringLength(50, ErrorMessage ="Instrument name cannot be longer than 50 characters")]
        [Display(Name = "Instrument Name")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Key of the instrument is required")]
        [Display(Name = "Key")]
        public string? Key { get; set; }

        public Musicians[]? Musicians { get; set; }

    }
}
