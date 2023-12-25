using System;
using System.Threading.Tasks;
using AutoMapper;
using Messager.Domain;
using Messager.Infastracture.User;
using Microsoft.EntityFrameworkCore;

namespace Messager.DataBase.EF.Repositories;

public class UserRepository : BaseRepository, IUserRepository
{
    private readonly DataContext _dbContext;
    private readonly IMapper _mapper;

    public UserRepository(DataContext dbContext, IMapper mapper) : base(dbContext)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<User?> GetByIdAsync(Guid id)
    {
        var userModel = await _dbContext.Users.FirstOrDefaultAsync(model => model.Id == id);
        if (userModel is null)
            return null;

        var user = _mapper.Map<User>(userModel);
        return user;
    }
}