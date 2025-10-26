using JACMS.API.Core.Configurations;
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
            services.Configure<DBConfig>(configuration.GetSection(DBConfig.ConfigurationSection));
            services.AddPostgreSQLDataAccess();
            return services;
        }
    }
}
