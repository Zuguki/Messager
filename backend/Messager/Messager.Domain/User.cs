using System;
using System.Collections.Generic;

namespace Messager.Domain;

public class User
{
    public Guid UserId { get; set; }
    
    public string UserName { get; set; } = null!;
    
    public string? Image { get; set; }

    public List<User>? Friends { get; set; }

    public List<Chat.Chat>? Chats { get; set; }
}