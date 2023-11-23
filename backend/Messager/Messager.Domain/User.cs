using System.Collections.Generic;

namespace Messager.Domain;

public class User
{
    public string UserName { get; set; } = null!;

    public string Email { get; set; } = null!;
    
    public List<Chat.Chat>? Chats { get; set; }
}