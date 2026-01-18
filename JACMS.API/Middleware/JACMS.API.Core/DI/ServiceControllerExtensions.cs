using JACMS.API.Core.Services.Security;
using JACMS.API.DataAccess.Core.Abstractions.Repositories.Identity;
using JACMS.API.DataAccess.Core.Models.Identity;
using JACMS.API.DataAccess.PostgreSQL.DI;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace JACMS.API.Core.DI
{
    public static class ServiceControllerExtensions
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddPostgreSQLDataAccess(config);
            services.AddIdentityServices();
            //add if postgress
            return services;
        }

        public static IServiceCollection AddIdentityServices(this IServiceCollection services)
        {
            services.AddIdentity<User, Role>();
            services.AddSingleton<IUserStore<User>>(x=> x.GetService<IUserRepository>());
            services.AddSingleton<IRoleStore<Role>>(x => x.GetService<IRoleRespository>());
            services.AddSingleton<IPasswordHasher<User>, JACMSPasswordHasher>();
            return services;
        }
    }
}
