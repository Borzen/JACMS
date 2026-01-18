using JACMS.API.DataAccess.Core.Models;
using JACMS.API.DataAccess.Core.Models.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.API.DataAccess.Core.Abstractions.Repositories.Identity
{
    public interface IUserRepository : IQueryableUserStore<User>, IUserStore<User>, IUserPasswordStore<User>, IUserEmailStore<User>
    {
    }
}
