using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCleanArchitecture.Domain.Contracts.Infrastructure;

namespace TestCleanArchitecture.Infrastructure
{
    public static class DataContextCollection
    {
        public static IServiceCollection AddDataContextCollection(this IServiceCollection services)
        {
            //services.AddDbContext();

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
