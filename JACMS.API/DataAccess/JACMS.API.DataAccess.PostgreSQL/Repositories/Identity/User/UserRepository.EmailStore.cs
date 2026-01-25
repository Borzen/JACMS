using JACMS.API.DataAccess.Core.Abstractions.Repositories.Identity;
using JACMS.API.DataAccess.Core.Models.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace JACMS.API.DataAccess.PostgreSQL.Repositories.Identity
{
    internal partial class UserRepository : IUserRepository
    {
        #region EmailStore Find
        public Task<User?> FindByEmailAsync(string normalizedEmail, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region EmailStore Get
        /// <inheritdoc/>
        public Task<string?> GetEmailAsync(User user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if(user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            return Task.FromResult(user.Email);
        }

        /// <inheritdoc/>
        public Task<bool> GetEmailConfirmedAsync(User user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if(user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            return Task.FromResult(user.EmailConfirmed);
        }

        /// <inheritdoc/>
        public Task<string?> GetNormalizedEmailAsync(User user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if (user == null)
            { 
                throw new ArgumentNullException(nameof(user));
            }

            return Task.FromResult(user.NormalizedEmail);
        }

        #endregion

        #region EmailStore Set

        /// <inheritdoc/>
        public Task SetEmailAsync(User user, string? email, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if(user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            user.Email = email;
            return Task.CompletedTask;
        }

        /// <inheritdoc/>
        public Task SetEmailConfirmedAsync(User user, bool confirmed, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if(user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            user.EmailConfirmed = confirmed;
            return Task.CompletedTask;
        }

        /// <inheritdoc/>
        public Task SetNormalizedEmailAsync(User user, string? normalizedEmail, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if(user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            user.NormalizedEmail = normalizedEmail;
            return Task.CompletedTask;
        }

        #endregion
    }
}
