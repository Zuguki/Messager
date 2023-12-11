using System;
using System.Linq;
using MediatR;
using Messager.Application.Behaviours;
using Messager.Application.Mediatr;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Messager.Extensions;

public static class ServiceExtension
{
    public static void AddCustomMediatR(this IServiceCollection collection)
    {
        var assemblies = AppDomain.CurrentDomain.GetAssemblies();
        collection.AddMediatR(config => config.AsScoped(), assemblies);
        
        var openGenericType = typeof(IValidator<>);
        var types = assemblies
            .SelectMany(a => a
                .GetTypes()
                .Where(t => t is {IsAbstract: false, IsGenericTypeDefinition: false}));

        foreach (var type in types)
        {
            var validatorInterface = type
                .GetInterfaces()
                .FirstOrDefault(t => t.IsGenericType && t.GetGenericTypeDefinition() == openGenericType);
    
            if (validatorInterface is not null)
                collection.AddSingleton(validatorInterface, type);
        }

        collection.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
    }

    public static void AddCustomSwaggerGen(this IServiceCollection collection)
    {
        collection.AddSwaggerGen(option =>
        {
            option.SwaggerDoc("v1", new OpenApiInfo {Title = "Messager.Api", Version = "v1"});
            option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                In = ParameterLocation.Header,
                Description = "Please enter a valid token",
                Name = "Authorization",
                Type = SecuritySchemeType.Http,
                BearerFormat = "JWT",
                Scheme = "Bearer"
            });
            option.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    Array.Empty<string>()
                }
            });
        });
    }
}