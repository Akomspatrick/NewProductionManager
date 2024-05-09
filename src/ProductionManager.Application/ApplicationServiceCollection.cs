﻿
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManager.Application;

public static class ApplicationServiceCollection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        var applicationAssembly = typeof(ApplicationServiceCollection).Assembly;
        services.AddMediatR(c => c.RegisterServicesFromAssemblyContaining<Class1>());
        //services.AddScoped<IPipelineBehavior<CreateModelTypeCommand, int>, ValidationModelTypeBehaviour>();
        //Instead of adding individual fluent validation we can add Fluentvalidation asp.netcore package and then 
        //services.AddScoped<IValidator<AddNewModelTypeCommand>, AddNewModelTypeValidator>();
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        return services;
    }
}
