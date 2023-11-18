using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Messager.Infastracture.EF;

public class DataContext : IdentityDbContext<User>
{
    private readonly IConfiguration _configuration = null!;

    public DataContext()
    {
    }

    public DataContext(DbContextOptions<DataContext> options, IConfiguration configuration) : base(options)
    {
        _configuration = configuration;
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = _configuration.GetConnectionString("Postgres");
        optionsBuilder.UseNpgsql(connectionString);
    }}