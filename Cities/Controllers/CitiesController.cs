using Cities.API;
using Cities.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cities.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<ICollection<CityDto>> GetCities()
        {
            return Ok(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{cityId}")]
        public ActionResult<CityDto> GetCity(int cityId)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(city => city.Id == cityId);
            if (city == null)
            {
                return NotFound();
            }
            return Ok(city);
        }
    }
}
