using System.Collections.Generic;

namespace Messager.Domain.Chat;

public abstract class Chat
{
    public string Name { get; set; } = null!;
    
    public abstract List<User> Subscribers { get; set; }

    public List<Message> Messages { get; set; } = new();
}