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
        public static IServiceCollection AddPostgreSQLDataAccess(this IServiceCollection services)
        {
            return services;
        }
    }
}
