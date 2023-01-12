using CommandsService.Dtos;
using CommandsService.Models;

namespace CommandsService.Profile
{
    public class CommandsProfile : AutoMapper.Profile
    {
        public CommandsProfile()
        {
            // Source => Target
            CreateMap<Platform, PlatformReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<Command, CommandReadDto>();
        }
    }
}