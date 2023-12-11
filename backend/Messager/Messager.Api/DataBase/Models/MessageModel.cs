using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Messager.DataBase.Models;

public class MessageModel
{
    [Key]
    [Column("id")]
    public Guid Id { get; init; }
    
    [Column("sender")]
    [ForeignKey(nameof(SenderId))]
    public UserModel Sender { get; init; } = null!;
    
    [Column("senderId")]
    public Guid SenderId { get; init; }

    [Column("text")]
    public string Text { get; init; } = null!;
    
    [Column("image")]
    public string? Image { get; init; }

}