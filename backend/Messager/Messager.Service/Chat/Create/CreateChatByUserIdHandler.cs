using System.Threading;
using System.Threading.Tasks;
using FluentResults;
using MediatR;
using Messager.Infastracture.Chat;
using Messager.Infastracture.User;

namespace Messager.Application.Chat.Create;

public class CreateChatByUserIdHandler : IRequestHandler<CreateChatByUserIdCommand, Result>
{
    private readonly IChatRepository _chatRepository;
    private readonly IUserRepository _userRepository;

    public CreateChatByUserIdHandler(IChatRepository chatRepository, IUserRepository userRepository)
    {
        _chatRepository = chatRepository;
        _userRepository = userRepository;
    }

    public async Task<Result> Handle(CreateChatByUserIdCommand request, CancellationToken cancellationToken)
    {
        return Result.Ok();
    }
}