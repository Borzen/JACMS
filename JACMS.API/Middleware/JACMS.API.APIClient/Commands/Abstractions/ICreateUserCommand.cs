using JACMS.API.Core.Models.Requests.User;
using JACMS.API.Core.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace JACMS.API.Client.Commands.Abstractions
{
    public interface ICreateUserCommand
    {
        Task<ResponseData> CreateNewUserAsync(UserCreationRequest request);
    }
}
