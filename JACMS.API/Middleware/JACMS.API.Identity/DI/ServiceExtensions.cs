using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace JACMS.API.Identity.DI
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddASPIdentity(this IServiceCollection services)
        {
            return services;
        }
    }
}
