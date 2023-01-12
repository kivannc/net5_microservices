using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Profile
{
    public class PlatformsProfile : AutoMapper.Profile
    {
        public PlatformsProfile()
        {
            // Source => Target
            CreateMap<Platform, PlatformReadDto>();
            CreateMap<PlatformCreateDto, Platform>();
            CreateMap<PlatformReadDto, PlatformPublishedDto>();
        }
    }
}