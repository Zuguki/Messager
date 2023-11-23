using System.Collections.Generic;

namespace Messager.Domain.Chat;

public class GroupChat : Chat
{
    public override List<User> Subscribers { get; set; } = new();
}