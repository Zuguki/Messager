using System;
using System.Threading.Tasks;
using AutoMapper;
using Messager.Domain;
using Messager.Infastracture.User;
using Microsoft.EntityFrameworkCore;

namespace Messager.DataBase.EF.Repositories;

public class UserRepository : IUserRepository
{
    private DataContext _context;
    private IMapper _mapper;

    public UserRepository(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }

    public async Task<User?> GetByIdAsync(Guid id)
    {
        var userModel = await _context.Users.FirstOrDefaultAsync(model => model.Id == id);
        if (userModel is null)
            return null;

        var user = _mapper.Map<User>(userModel);
        return user;
    }
}