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
using System.Text;

namespace JACMS.API.DataAccess.PostgreSQL.Repositories.Identity
{
    internal partial class RoleRepository : IRoleRespository
    {
        private readonly IDbContext _dbContext;
        private ILogger<RoleRepository> _logger;

        public IQueryable<Role> Roles
        {
            get
            {
                using (var connection = _dbContext.GetDbConnection())
                {
                    return connection.Query<Role>("Select * fron \"Identity\".Role").AsQueryable();
                }
            }
        }

        public RoleRepository(IDbContext dbContext, ILogger<RoleRepository> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        #region Create Update Delete
        public async Task<IdentityResult> CreateAsync(Role role, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if (role == null)
            {
                throw new ArgumentNullException(nameof(role));
            }

            using (var connection = _dbContext.GetDbConnection())
            {
                try
                {
                    var dynamicParams = role.GetCreateDynamicParams();
                    dynamicParams.Add("new_role_id", dbType: System.Data.DbType.Int64, direction: System.Data.ParameterDirection.Output);
                    await connection.ExecuteAsync(SQLCommands.Identity.Role.Create, dynamicParams, commandType: System.Data.CommandType.StoredProcedure);
                    var newRoleId = dynamicParams.Get<long>("new_role_id");
                    role.Id = newRoleId;
                    return IdentityResult.Success;
                }
                catch (Exception ex)
                {
                    //handle error
                    throw;
                }
            }
        }

        public async Task<IdentityResult> UpdateAsync(Role role, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            using (var connection = _dbContext.GetDbConnection())
            {
                try
                {
                    var dynamicParams = role.GetUpdateDynamicParams();
                    await connection.ExecuteAsync(SQLCommands.Identity.Role.Update, dynamicParams, commandType: System.Data.CommandType.StoredProcedure);
                    return IdentityResult.Success;
                }
                catch (Exception ex)
                {
                    //handle error
                    throw;
                }
            }
        }

        public Task<IdentityResult> DeleteAsync(Role role, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Gets

        /// <inheritdoc/>
        public Task<string> GetRoleIdAsync(Role role, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if(role == null)
            {
                throw new ArgumentNullException(nameof(role));
            }

            return Task.FromResult(role.Id.ToString());
        }

        /// <inheritdoc/>
        public Task<string?> GetRoleNameAsync(Role role, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if (role == null)
            {
                throw new ArgumentNullException(nameof(role));
            }

            return Task.FromResult(role.Name);
        }

        /// <inheritdoc/>
        public Task<string?> GetNormalizedRoleNameAsync(Role role, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if(role == null)
            {
                throw new ArgumentNullException(nameof(role));
            }

            return Task.FromResult(role.NormalizedName);
        }

        #endregion

        #region Sets
        
        /// <inheritdoc/>
        public Task SetRoleNameAsync(Role role, string? roleName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if(role == null)
            {
                throw new ArgumentNullException(nameof(role));
            }

            role.Name = roleName;
            return Task.CompletedTask;
        }

        /// <inheritdoc/>
        public Task SetNormalizedRoleNameAsync(Role role, string? normalizedName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if(role == null)
            {
                throw new ArgumentNullException(nameof(role));
            }

            role.NormalizedName = normalizedName;
            return Task.CompletedTask;
        }

        #endregion

        #region Finds
        public Task<Role?> FindByIdAsync(string roleId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Role?> FindByNameAsync(string normalizedRoleName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
