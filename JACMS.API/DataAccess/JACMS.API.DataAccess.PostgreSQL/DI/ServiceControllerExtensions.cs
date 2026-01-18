using JACMS.API.DataAccess.Core;
using JACMS.API.DataAccess.Core.Abstractions.Repositories.Identity;
using JACMS.API.DataAccess.PostgreSQL.Repositories.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.API.DataAccess.PostgreSQL.DI
{
    public static class ServiceControllerExtensions
    {
        public static IServiceCollection AddPostgreSQLDataAccess(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<IDbContext, DbContext>();
            services.AddSingleton<IUserRepository, UserRepository>();
            services.AddSingleton<IRoleRespository, RoleRepository>();
            return services;
        }
    }
}
