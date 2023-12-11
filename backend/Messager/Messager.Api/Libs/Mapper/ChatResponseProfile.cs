using AutoMapper;
using Messager.DataBase.Models;
using Messager.Domain.Chat;

namespace Messager.Libs.Mapper;

public class ChatResponseProfile : Profile
{
    public ChatResponseProfile()
    {
        CreateMap<ChatModel, Chat>()
            .ForMember(nameof(Chat.Id), cfg => cfg.MapFrom(src => src.Id))
            .ForMember(nameof(Chat.Name), cfg => cfg.MapFrom(src => src.Name))
            .ForMember(nameof(Chat.Messages), cfg => cfg.MapFrom(src => src.Messages))
            .ReverseMap();
    }
}