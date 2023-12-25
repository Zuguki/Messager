using System;
using System.Threading.Tasks;

namespace Messager.Infastracture.Chat;

public interface IChatRepository : IRepository
{
    Task<Domain.Chat.Chat?> GetByIdAsync(Guid id);

    Task CreateAsync(Domain.Chat.Chat chat);
}