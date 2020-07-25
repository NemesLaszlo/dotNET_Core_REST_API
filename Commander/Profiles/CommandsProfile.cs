using AutoMapper;
using Commander.Dtos;
using Commander.Models;

namespace Commander.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            // Source -> Target
            CreateMap<Command, CommandReadDto>(); //  for GET
            CreateMap<CommandCreateDto, Command>(); //  for POST
            CreateMap<CommandUpdateDto, Command>(); // for PUT
            CreateMap<Command, CommandUpdateDto>(); // for PATCH
        }

    }

}

