using System;
using System.Collections.Generic;

namespace Messager.Infastracture.User.Dto;

public class GetUserResponse
{
    public Guid UserId { get; set; }
    
    public string UserName { get; set; } = null!;
    
    public string? Image { get; set; }

    public List<Domain.User>? Friends { get; set; }
}