using System;
using System.Threading.Tasks;
using FluentResults;
using Messager.Infastracture.User.Dto;

namespace Messager.Infastracture.User;

public interface IUserRepository
{
    Task<Result<GetUserResponse>> GetUser(GetUserRequest request);
}