using System;
using System.Text.Json.Serialization;
using FluentResults;
using MediatR;

namespace Messager.Application.Chat.Create;

public class CreateChatByUserIdCommand : IRequest<Result>
{
    [JsonPropertyName("userId")]
    public Guid UserId { get; init; }
}