using Messager.DataBase.EF;
using Messager.DataBase.Models;
using Messager.Extensions;
using Messager.Libs.Serilog;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseSerilog(SerilogConfiguration.Connect);

builder.Services.AddAuthentication().AddBearerToken(IdentityConstants.BearerScheme);
builder.Services.AddAuthorizationBuilder();
builder.Services.AddDbContext<DataContext>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddIdentityCore<UserModel>()
    .AddEntityFrameworkStores<DataContext>()
    .AddApiEndpoints();

builder.Services.AddCustomMediatR();
builder.Services.AddCustomSwaggerGen();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapIdentityApi<UserModel>();
app.MapControllers();

app.Run();