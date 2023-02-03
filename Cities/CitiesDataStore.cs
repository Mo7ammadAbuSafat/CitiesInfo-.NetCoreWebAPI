using Cities.API.Models;
using Cities.Models;

namespace Cities.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }

        public static CitiesDataStore Current { get; set; } = new CitiesDataStore();

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Jenin",
                    Description = "Jenin Description",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Jenin Center",
                            Description = "Center point of jenin city"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Jenin Mousqe",
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Tulkarm",
                    Description = "Tulkarm Description",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Tulkarm Center",
                            Description = "Center point of Tulkarm city"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "Tulkarm Mousqe",
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Nablus",
                    Description = "Nablus Description",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 5,
                            Name = "Nablus Center",
                            Description = "Center point of Nablus city"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 6,
                            Name = "Nablus Mousqe",
                        }
                    }
                }
            };
        }
    }
}
