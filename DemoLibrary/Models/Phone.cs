using System.ComponentModel.DataAnnotations;

namespace DemoLibrary.Models
{
    public class Phone
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string PhoneNumber { get; set; }
    }
}
