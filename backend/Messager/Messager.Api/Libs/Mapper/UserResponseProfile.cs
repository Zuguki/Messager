using AutoMapper;
using Messager.DataBase.Models;
using Messager.Domain;

namespace Messager.Libs.Mapper;

public class UserResponseProfile : Profile
{
    public UserResponseProfile()
    {
        CreateMap<UserModel, User>()
            .ForMember(nameof(User.Id), cfg => cfg.MapFrom(src => src.Id))
            .ForMember(nameof(User.UserName), cfg => cfg.MapFrom(src => src.UserName))
            .ForMember(nameof(User.Chats), cfg => cfg.MapFrom(src => src.Chats))
            .ReverseMap();
    }
}