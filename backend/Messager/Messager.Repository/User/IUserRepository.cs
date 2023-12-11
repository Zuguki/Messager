using System;
using System.Threading.Tasks;

namespace Messager.Infastracture.User;

public interface IUserRepository : IRepository
{
    Task<Domain.User?> GetByIdAsync(Guid id);
}