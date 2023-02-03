using Cities.Models;

namespace Cities.API.Models
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public ICollection<PointOfInterestDto> PointsOfInterest { get; set; } = new List<PointOfInterestDto>();

        public int NumberOfPointInterest
        {
            get
            {
                return PointsOfInterest.Count;
            }
        }
    }
}
