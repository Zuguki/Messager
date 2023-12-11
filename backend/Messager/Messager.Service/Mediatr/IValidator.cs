using FluentResults;
using MediatR;

namespace Messager.Application.Mediatr;

public interface IValidator<in T> where T : IBaseRequest
{
    Result Validate(T request);
}