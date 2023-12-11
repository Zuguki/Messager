using System;
using FluentResults;
using Messager.Application.Mediatr;

namespace Messager.Application.Chat.Create;

public class CreateChatByUserIdValidator : IValidator<CreateChatByUserIdCommand>
{
    public Result Validate(CreateChatByUserIdCommand request)
    {
        if (request.UserId == Guid.Empty)
            return Result.Fail("Передан некорректный идентификатор пользователя");

        return Result.Ok();
    }
}