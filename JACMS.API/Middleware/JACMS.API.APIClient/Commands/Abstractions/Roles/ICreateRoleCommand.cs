using JACMS.API.Core.Models.Requests.Role;
using JACMS.API.Core.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace JACMS.API.Client.Commands.Abstractions.Roles
{
    public interface ICreateRoleCommand
    {
        Task<ResponseData> CreateNewRoleAsync(CreateRoleRequest request);
    }
}
