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
    
    [Column("users")]
    public List<UserModel> Users { get; init; }
}