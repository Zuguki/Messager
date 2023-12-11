using AutoMapper;
using Messager.DataBase.Models;
using Messager.Domain;

namespace Messager.Libs.Mapper;

public class MessageResponseProfile : Profile
{
    public MessageResponseProfile()
    {
        CreateMap<MessageModel, Message>()
            .ForMember(nameof(Message.Id), cfg => cfg.MapFrom(src => src.Id))
            .ForMember(nameof(Message.Sender), cfg => cfg.MapFrom(src => src.Sender))
            .ForMember(nameof(Message.Text), cfg => cfg.MapFrom(src => src.Text))
            .ForMember(nameof(Message.Image), cfg => cfg.MapFrom(src => src.Image))
            .ReverseMap();
    }
}