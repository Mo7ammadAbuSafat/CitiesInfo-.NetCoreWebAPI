using System.ComponentModel.DataAnnotations;

namespace Cities.Models
{
    public class PointOfInterestForCreationDto
    {
        [Required]
        public string Name { get; set; }

        [MaxLength(100)]
        public string? Description { get; set; }
    }
}
