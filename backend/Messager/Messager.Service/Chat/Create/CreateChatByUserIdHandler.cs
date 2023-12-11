using System.Net.Http;
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
    private readonly HttpContent _content;

    public CreateChatByUserIdHandler(IChatRepository chatRepository, IUserRepository userRepository, HttpContent content)
    {
        _chatRepository = chatRepository;
        _userRepository = userRepository;
        _content = content;
    }

    public async Task<Result> Handle(CreateChatByUserIdCommand request, CancellationToken cancellationToken)
    {
        return Result.Ok();
    }
}