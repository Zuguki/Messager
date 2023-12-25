using System;
using System.Threading.Tasks;
using AutoMapper;
using Messager.DataBase.Models;
using Messager.Domain.Chat;
using Messager.Infastracture.Chat;
using Microsoft.EntityFrameworkCore;

namespace Messager.DataBase.EF.Repositories;

public class ChatRepository : BaseRepository, IChatRepository
{
    private readonly DataContext _dbContext;
    private readonly IMapper _mapper;

    public ChatRepository(DataContext dbContext, IMapper mapper) : base(dbContext)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }


    public async Task<Chat?> GetByIdAsync(Guid id)
    {
        var model = await _dbContext.Chats
            .Include(chat => chat.Users)
            .FirstOrDefaultAsync(chat => chat.Id == id);

        if (model is null)
            return null;

        return _mapper.Map<Chat>(model);
    }

    public async Task CreateAsync(Chat chat)
    {
        var model = _mapper.Map<ChatModel>(chat);
        await _dbContext.Chats.AddAsync(model);
    }
}