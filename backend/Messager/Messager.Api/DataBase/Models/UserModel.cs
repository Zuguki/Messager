using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Messager.DataBase.Models;

public class UserModel : IdentityUser<Guid>
{
    [Column("chats")]
    public List<ChatModel> Chats { get; init; }
}