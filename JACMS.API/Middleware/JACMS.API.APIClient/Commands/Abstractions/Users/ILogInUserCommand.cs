using JACMS.API.Core.Models.Requests.User;
using JACMS.API.Core.Models.Response;
using JACMS.API.Core.Models.Response.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace JACMS.API.Client.Commands.Abstractions.Users
{
    public interface ILogInUserCommand
    {
        Task<ResponseData<AuthResponse>> HandleLogInRequestAsync(AuthRequest request);
    }
}
