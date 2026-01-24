using Dapper;
using JACMS.API.DataAccess.Core.Abstractions.Repositories.Identity;
using JACMS.API.DataAccess.Core.Models.Helpers.Identity;
using JACMS.API.DataAccess.Core.Models.Identity;
using JACMS.API.DataAccess.PostgreSQL.Helpers;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace JACMS.API.DataAccess.PostgreSQL.Repositories.Identity
{
    internal partial class UserRepository : IUserRoleRepository
    {
        public async Task AddToRoleAsync(User user, string roleName, CancellationToken cancellationToken)
        {
            if(user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            using (var connection = _dbContext.GetDbConnection())
            {
                try
                {
                    DynamicParameters roleDynamicParams = new DynamicParameters();
                    roleDynamicParams.Add("NormalizedName", roleName);
                    var role = await connection.QueryFirstOrDefaultAsync<IdentityRole<long>>(SQLCommands.Identity.Role.GetByNormalizedName, roleDynamicParams);
                    if (role == null)
                    {
                        //handle error;
                        return;
                    }

                    await connection.ExecuteAsync(SQLCommands.Identity.UserRole.Create, user.GetCreateUserRoleDynamicParams(0), commandType: System.Data.CommandType.StoredProcedure);
                }
                catch (Exception ex)
                {
                    //handle error;
                    throw;
                }
            }
        }

        public Task<IList<string>> GetRolesAsync(User user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IList<User>> GetUsersInRoleAsync(string roleName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsInRoleAsync(User user, string roleName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task RemoveFromRoleAsync(User user, string roleName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
