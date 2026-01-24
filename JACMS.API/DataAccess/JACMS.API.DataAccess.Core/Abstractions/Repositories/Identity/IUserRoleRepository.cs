using JACMS.API.DataAccess.Core.Models.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace JACMS.API.DataAccess.Core.Abstractions.Repositories.Identity
{
    public interface IUserRoleRepository : IUserRoleStore<User>
    {
    }
}
