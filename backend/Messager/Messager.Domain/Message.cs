using System;

namespace Messager.Domain;

public class Message
{
    public Guid Id;
    
    public User Sender { get; set; } = null!;
    
    public string Text { get; set; } = null!;
    
    public string? Image { get; set; }
}