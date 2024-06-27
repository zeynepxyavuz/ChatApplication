using AutoMapper;
using ChatApp.Models;
using ChatApp.Dto;
using ChatApp.Models;

namespace ChatApp.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Group, GroupDto>().ReverseMap();
            CreateMap<Message, MessageDto>().ReverseMap();
            CreateMap<AppUser, UserDto>().ReverseMap();
        }
    }
}

