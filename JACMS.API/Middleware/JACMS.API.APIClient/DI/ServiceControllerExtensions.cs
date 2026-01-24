using JACMS.API.Client.Commands.Abstractions;
using JACMS.API.Client.Commands.Users;
using JACMS.API.Core.Configurations;
using JACMS.API.Core.DI;
using JACMS.API.DataAccess.PostgreSQL.DI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace JACMS.API.Client.DI
{
    public static class ServiceControllerExtensions 
    {
        public static IServiceCollection AddApiClient(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddCoreServices(configuration);
            services.AddScoped<ICreateUserCommand, CreateUserCommand>();

            return services;
        }
    }
}
