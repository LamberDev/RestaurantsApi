using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Application.Interfaces;
using Persistence.Repositoty;

namespace Infraestructure.Persistence
{
    public static class ServiceExtensions
    {
        public static void AddPersistenceInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RestaurantDbContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("DefaultConnecion"),
                b => b.MigrationsAssembly(typeof(RestaurantDbContext).Assembly.FullName)));

            #region Respositories
            services.AddTransient(typeof(IRepositoryAsync<>), typeof(RestaurantRepository<>));
            #endregion
        }
    }
}
