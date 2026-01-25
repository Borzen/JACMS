using Dapper;
using JACMS.API.DataAccess.Core;
using JACMS.API.DataAccess.Core.Abstractions.Repositories.Identity;
using JACMS.API.DataAccess.Core.Models.Helpers.Identity;
using JACMS.API.DataAccess.Core.Models.Identity;
using JACMS.API.DataAccess.PostgreSQL.Helpers;
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
    internal partial class UserRepository : IUserRepository
    {
        private readonly IDbContext _dbContext;
        private ILogger<UserRepository> _logger;

        public IQueryable<User> Users {
            get
            {
                using (var connection = _dbContext.GetDbConnection())
                {
                    return connection.Query<User>("Select * fron Identity.User").AsQueryable();
                }
            }
        }

        public UserRepository(IDbContext dbContext, ILogger<UserRepository> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        #region Create Delete Update

        /// <inheritdoc/>
        public async Task<IdentityResult> CreateAsync(User user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if(user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            using (var connection = _dbContext.GetDbConnection())
            {
                try
                {
                    var dynamicParams = user.GetCreateDynamicParams(':', true);
                    dynamicParams.Add(":new_user_id", direction: System.Data.ParameterDirection.Output);
                    await connection.ExecuteAsync(SQLCommands.Identity.User.Create, dynamicParams, commandType: System.Data.CommandType.StoredProcedure);
                    var newUserId = dynamicParams.Get<long>("new_user_id");
                    user.Id = newUserId;
                    return IdentityResult.Success;
                }
                catch (Exception ex)
                {
                    //handle error
                    throw;
                }
            }
        }

        public Task<IdentityResult> DeleteAsync(User user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> UpdateAsync(User user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region UserStore Finds
        public Task<User> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<User> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            using (var connection = _dbContext.GetDbConnection())
            {
                try
                {
                    DynamicParameters dynamicParams = new DynamicParameters();
                    dynamicParams.Add("normalized_name", normalizedUserName);

                    var sql = FunctionMapperHelper.GenerateFunctionStatement(SQLCommands.Identity.User.GetByNormalizedName, dynamicParams);

                    var user = await connection.QueryFirstOrDefaultAsync<User>(sql, dynamicParams);
                    return user;
                }
                catch (Exception ex)
                {
                    //handle error
                    throw;
                }
            }
        }
        #endregion

        #region UserStore Gets

        /// <inheritdoc/>
        public Task<string> GetNormalizedUserNameAsync(User user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            return Task.FromResult(user.NormalizedUserName);
        }

        /// <inheritdoc/>
        public Task<string> GetUserIdAsync(User user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            return Task.FromResult(user.Id.ToString());
        }

        /// <inheritdoc/>
        public Task<string> GetUserNameAsync(User user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if(user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            return Task.FromResult(user.UserName);
        }

        #endregion

        #region UserStore Sets

        /// <inheritdoc/>
        public Task SetNormalizedUserNameAsync(User user, string normalizedName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            user.NormalizedUserName = normalizedName;
            return Task.CompletedTask;
        }

        /// <inheritdoc/>
        public Task SetUserNameAsync(User user, string userName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            user.UserName = userName;
            return Task.CompletedTask;
        }

        #endregion
    }
}
