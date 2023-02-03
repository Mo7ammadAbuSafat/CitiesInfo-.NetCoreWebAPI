using Cities.API;
using Microsoft.AspNetCore.Mvc;

namespace Cities.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public JsonResult GetCities()
        {
            return new JsonResult(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{Id}")]
        public JsonResult GetCity(int Id)
        {
            return new JsonResult(CitiesDataStore.Current.Cities.FirstOrDefault(city => city.Id == Id));
        }
    }
}
