using System;
using System.Collections.Generic;

namespace Messager.Domain;

public class User
{
    public Guid Id { get; set; }
    
    public string UserName { get; set; } = null!;
    
    public List<Chat.Chat>? Chats { get; set; }
}