using System.Threading.Tasks;
using FluentResults;

namespace Messager.Infastracture;

public interface IRepository
{
    Task SaveChangesAsync();
}