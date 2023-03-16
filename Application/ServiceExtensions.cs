using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Application.Behaviours;

namespace Application
{
    public static class ServiceExtensions
    {
        public static void AddApplicationLayer(this IServiceCollection _services)
        {
            _services.AddAutoMapper(Assembly.GetExecutingAssembly());
            _services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            _services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            _services.AddTransient(typeof(IPipelineBehavior<,>),typeof(ValidationBehaviour<,>));
        }
    }
}
