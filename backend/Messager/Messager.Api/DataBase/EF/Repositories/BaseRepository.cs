using System.Threading.Tasks;
using Messager.Infastracture;

namespace Messager.DataBase.EF.Repositories;

public class BaseRepository : IRepository
{
    private readonly DataContext _dbContext;

    public BaseRepository(DataContext dbContext)
    {
        _dbContext = dbContext;
    }

    public virtual async Task SaveChangesAsync() => await _dbContext.SaveChangesAsync();
}