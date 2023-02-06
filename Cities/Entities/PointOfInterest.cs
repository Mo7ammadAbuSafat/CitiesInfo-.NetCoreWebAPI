using System.ComponentModel.DataAnnotations;

namespace Cities.Entities
{
    public class PointOfInterest
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }

        public City? City { get; set; }
        public int CityId { get; set; }
    }
}