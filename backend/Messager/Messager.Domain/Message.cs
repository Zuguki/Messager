namespace Messager.Domain;

public class Message
{
    public User Sender { get; set; } = null!;
    
    public string Text { get; set; } = null!;
    
    public string? Image { get; set; }
}