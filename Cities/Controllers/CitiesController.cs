using AutoMapper;
using Cities.Models;
using Cities.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Cities.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        private readonly ICityInfoRepository cityInfoRepository;
        private readonly IMapper mapper;

        public CitiesController(ICityInfoRepository cityInfoRepository, IMapper mapper)
        {
            this.cityInfoRepository = cityInfoRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CityWithoutPointsOfInterestDto>>> GetCities()
        {
            var cities = await cityInfoRepository.GetCitiesAsync();
            return Ok(mapper.Map<IEnumerable<CityWithoutPointsOfInterestDto>>(cities));
        }

        [HttpGet("{cityId}")]
        public async Task<IActionResult> GetCity(int cityId, bool includePointsOfInterest = false)
        {
            var city = await cityInfoRepository.GetCityAsync(cityId, includePointsOfInterest);
            if (city == null)
            {
                return NotFound();
            }

            if (includePointsOfInterest)
            {
                return Ok(mapper.Map<CityDto>(city));
            }
            return Ok(mapper.Map<CityWithoutPointsOfInterestDto>(city));

        }
    }
}
