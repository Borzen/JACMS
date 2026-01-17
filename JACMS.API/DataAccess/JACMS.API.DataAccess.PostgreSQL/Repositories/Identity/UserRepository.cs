using Dapper;
using JACMS.API.DataAccess.Core.Abstractions.Repositories;
using JACMS.API.DataAccess.Core.Models.Identity;
using JACMS.API.DataAccess.PostgreSQL.Helpers;
using JACMS.API.DataAccess.PostgreSQL.Helpers.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.API.DataAccess.PostgreSQL.Repositories.Identity
{
    internal class UserRepository : IUserRepository
    {
        private readonly DbContext _dbContext;
        private ILogger<UserRepository> _logger;

        public UserRepository(DbContext dbContext, ILogger<UserRepository> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public async Task<IdentityResult> CreateAsync(User user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if(user == null)
            {
                return null;
            }

            using (var connection = _dbContext.GetDbConnection())
            {
                var transaction = connection.BeginTransaction();
                try
                {
                    user.Id = await connection.ExecuteScalarAsync<int>(StoredProcedures.Identity.User.CreateUser, user.GetCreateDynamicParams(), commandType: System.Data.CommandType.StoredProcedure);
                }
                catch(Exception ex)
                {
                    //handle error
                    return IdentityResult.Failed();
                }
                return IdentityResult.Success;
            }
        }

        public Task<IdentityResult> DeleteAsync(User user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<User> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<User> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetNormalizedUserNameAsync(User user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetUserIdAsync(User user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetUserNameAsync(User user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetNormalizedUserNameAsync(User user, string normalizedName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetUserNameAsync(User user, string userName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> UpdateAsync(User user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
