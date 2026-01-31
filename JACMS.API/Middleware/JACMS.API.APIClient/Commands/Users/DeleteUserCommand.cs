using JACMS.API.Client.Commands.Abstractions.Users;
using JACMS.API.Core.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace JACMS.API.Client.Commands.Users
{
    public class DeleteUserCommand : IDeleteUserCommand
    {
        public Task<ResponseData> DeleteUserAsync(long userId)
        {
            throw new NotImplementedException();
        }
    }
}
