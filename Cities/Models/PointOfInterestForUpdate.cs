using System.ComponentModel.DataAnnotations;

namespace Cities.Models
{
    public class PointOfInterestForUpdate
    {
        [Required]
        public string Name { get; set; }

        [MaxLength(100)]
        public string? Description { get; set; }
    }
}
