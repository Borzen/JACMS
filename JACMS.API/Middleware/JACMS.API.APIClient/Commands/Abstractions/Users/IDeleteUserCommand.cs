using JACMS.API.Core.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace JACMS.API.Client.Commands.Abstractions.Users
{
    public interface IDeleteUserCommand
    {
        Task<ResponseData> DeleteUserAsync(long userId);
    }
}
