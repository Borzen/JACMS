using JACMS.API.Client.Commands.Abstractions;
using JACMS.API.Core.Models.Requests.User;
using JACMS.API.Core.Models.Response;
using JACMS.API.Core.Services.Identity;
using JACMS.API.DataAccess.Core.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace JACMS.API.Client.Commands.Users
{
    public class CreateUserCommand : ICreateUserCommand
    {
        private readonly UserManager<User> _userManager;
        private readonly ILogger<CreateUserCommand> _logger;

        public CreateUserCommand(UserManager<User> userManager, ILogger<CreateUserCommand> logger)
        {
            _userManager = userManager;
            _logger = logger;
        }

        public async Task<ResponseData> CreateNewUserAsync(UserCreationRequest request)
        {
            //do basic 
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            User user = new User
            {
                Email = request.Email,
                UserName = request.UserName,
            };

            if (!string.IsNullOrEmpty(request.PhoneNumber))
            {
                user.PhoneNumber = request.PhoneNumber;
            }

            IdentityResult result = await _userManager.CreateAsync(user, request.Password);

            ResponseData responseData = new ResponseData()
            {
                Successful = result.Succeeded,
                ErrorMessages = result.Errors?.Select(x => x.Description).ToList()
            };

            return responseData;
        }
    }
}
