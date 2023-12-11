using System;
using Messager.DataBase.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Messager.DataBase.EF;

public class DataContext : IdentityDbContext<UserModel, IdentityRole<Guid>, Guid>
{
    public DbSet<ChatModel> Chats { get; set; } = null!;
    public DbSet<MessageModel> Messages { get; set; } = null!;
    
    private readonly IConfiguration _configuration = null!;
    
    public DataContext(DbContextOptions<DataContext> options, IConfiguration configuration) : base(options)
    {
        _configuration = configuration;
        Database.Migrate();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = _configuration.GetConnectionString("Postgres");
        optionsBuilder.UseNpgsql(connectionString);
    }}