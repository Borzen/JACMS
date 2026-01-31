using JACMS.API.Client.Commands.Abstractions.Roles;
using JACMS.API.Core.Models.Requests.Role;
using JACMS.API.Core.Models.Response;
using JACMS.API.DataAccess.Core.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace JACMS.API.Client.Commands.Roles
{
    public class CreateRoleCommand : ICreateRoleCommand
    {
        private readonly RoleManager<Role> _roleManager;
        private readonly ILogger<CreateRoleCommand> _logger;

        public CreateRoleCommand(RoleManager<Role> roleManager, ILogger<CreateRoleCommand> logger)
        {
            _roleManager = roleManager;
            _logger = logger;
        }

        public async Task<ResponseData> CreateNewRoleAsync(CreateRoleRequest request)
        {
            //do basic error checking.
            if(request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            Role role = new Role()
            {
                Name = request.Name,
            };

            var result = await _roleManager.CreateAsync(role);

            ResponseData responseData = new ResponseData()
            {
                Successful = result.Succeeded,
                ErrorMessages = result.Errors?.Select(x=>x.Description).ToList()
            };

            return responseData;
        }
    }
}
