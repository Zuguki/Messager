using System;
using System.Collections.Generic;
using Messager.Domain;

namespace Messager.Infastracture.Chat.Dto;

public class GetChatByIdDto
{
    public Guid Id { get; init; }
    
    public string Name { get; set; } = null!;

    public List<User> Subscribers { get; set; } = new();

    public List<Message> Messages { get; set; } = new();
}