using System.Threading.Tasks;
using FluentResults;
using Messager.Infastracture.Chat.Dto;

namespace Messager.Infastracture.Chat;

public interface IChatRepository
{
    Task<Result<GetChatByIdDto>> GetChatByIdAsync();
}