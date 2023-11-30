using System;

namespace Messager.Infastracture.User.Dto;

public class AddFriendRequest
{
    public Guid SenderUserId { get; set; }
    
    public Guid DestinationUserId { get; set; }
}