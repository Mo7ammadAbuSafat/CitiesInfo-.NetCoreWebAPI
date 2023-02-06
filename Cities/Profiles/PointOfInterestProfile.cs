using AutoMapper;
using Cities.Entities;
using Cities.Models;

namespace CityInfo.Profiles
{
    public class PointOfInterestProfile : Profile
    {
        public PointOfInterestProfile()
        {
            CreateMap<PointOfInterest, PointOfInterestDto>();
            CreateMap<PointOfInterestForCreation, PointOfInterest>();
            CreateMap<PointOfInterestForUpdate, PointOfInterest>();
            CreateMap<PointOfInterest, PointOfInterestForUpdate>();
        }
    }
}
