using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Messager.DataBase.Models;

public class ChatModel
{
    [Key]
    [Column("id")]
    public Guid Id { get; init; }

    [Column("name")]
    public string Name { get; init; } = null!;
    
    [Column("users")]
    public List<UserModel> Users { get; init; } = null!;
    
    [Column("messages")]
    public List<MessageModel> Messages { get; init; } =null!;
}