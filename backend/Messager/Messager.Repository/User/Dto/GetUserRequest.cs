using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Messager.Infastracture.User.Dto;

public class GetUserRequest
{
    [Required]
    [JsonPropertyName("userId")]
    public Guid UserId { get; set; }
}