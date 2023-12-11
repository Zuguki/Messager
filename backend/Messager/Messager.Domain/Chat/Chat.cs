using System;
using System.Collections.Generic;

namespace Messager.Domain.Chat;

public class Chat
{
    public Guid Id { get; init; }
    
    public string Name { get; set; } = null!;

    public List<User> Subscribers { get; set; } = new();

    public List<Message> Messages { get; set; } = new();
}