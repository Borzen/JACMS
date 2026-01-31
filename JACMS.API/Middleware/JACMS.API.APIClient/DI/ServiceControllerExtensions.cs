using JACMS.API.Client.Commands.Abstractions.Roles;
using JACMS.API.Client.Commands.Abstractions.Users;
using JACMS.API.Client.Commands.Roles;
using JACMS.API.Client.Commands.Users;
using JACMS.API.Core.DI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace JACMS.API.Client.DI
{
    public static class ServiceControllerExtensions 
    {
        public static IServiceCollection AddApiClient(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddCoreServices(configuration);

            #region User Commands
            services.AddScoped<ICreateUserCommand, CreateUserCommand>();
            services.AddScoped<IUpdateUserCommand, UpdateUserCommand>();
            services.AddScoped<IDeleteUserCommand, DeleteUserCommand>();
            services.AddScoped<ILogInUserCommand,  LogInUserCommand>();
            #endregion

            #region Role Commands
            services.AddScoped<ICreateRoleCommand, CreateRoleCommand>();
            services.AddScoped<IUpdateRoleCommand, UpdateRoleCommand>();
            services.AddScoped<IDeleteRoleCommand, DeleteRoleCommand>();
            #endregion

            return services;
        }
    }
}
