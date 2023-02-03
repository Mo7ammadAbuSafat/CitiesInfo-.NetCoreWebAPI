using Cities.API.Models;

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
                    Description = "Jenin Description"
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Tulkarm",
                    Description = "Tulkarm Description"
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Nablus",
                    Description = "Nablus Description"
                }
            };
        }
    }
}
