using CommandService.Dtos;
using CommandService.Models;

namespace CommandService.Profile
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