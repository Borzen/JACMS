using JACMS.API.Client.Commands.Abstractions.Users;
using JACMS.API.Core.Exceptions;
using JACMS.API.Core.Models.Requests.User;
using JACMS.API.Core.Models.Response;
using JACMS.API.Core.Models.Response.User;
using JACMS.API.DataAccess.Core.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JACMS.API.Client.Commands.Users
{
    public class LogInUserCommand : ILogInUserCommand
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ILogger<LogInUserCommand> _logger;

        private string _jwtTokenKey;

        public LogInUserCommand(UserManager<User> userManager, SignInManager<User> signInManager, ILogger<LogInUserCommand> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        public async Task<ResponseData<AuthResponse>> HandleLogInRequestAsync(AuthRequest request)
        {
            if(request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            User user;

            if (!string.IsNullOrEmpty(request.UserName))
            {
                user = await _userManager.FindByNameAsync(request.UserName);
            }
            else if (!string.IsNullOrEmpty(request.Email))
            {
                user = await _userManager.FindByEmailAsync(request.Email);
            }
            //else if(true)
            //{
            //    user = await _userManager.FindByLoginAsync("provider", "key");
            //}
            else
            {
                throw new AuthException("No UserName or Email provided.");
            }

            SignInResult result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);
            if(!result.Succeeded)
            {
                return new ResponseData<AuthResponse>()
                {
                    Data = null,
                    Successful = false,
                    ErrorMessages = GenerateErrorList(result)
                };
            }

            var roles = await _userManager.GetRolesAsync(user);

            var authResult = new ResponseData<AuthResponse>()
            {
                Data = new AuthResponse(),
                Successful = result.Succeeded,
            };
            if (!string.IsNullOrEmpty(request.UserName))
            {
                authResult.Data.Token = GenerateAuthToken(roles, userName: request.UserName);
            }
            else if (!string.IsNullOrEmpty(request.Email))
            {
                authResult.Data.Token = GenerateAuthToken(roles, email: request.Email);
            }

            return authResult;
        }

        private List<string> GenerateErrorList(SignInResult result)
        {
            List<string> errors = new List<string>();
            return errors;
        }

        private string GenerateAuthToken(IList<string> userRoles, string userName = "", string email = "")
        {
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            byte[] key = Encoding.UTF8.GetBytes(_jwtTokenKey);
            List<Claim> claims = new List<Claim>();
            if (!string.IsNullOrEmpty(userName))
            {
                new Claim(ClaimTypes.Name, userName);
            }
            else if(!string.IsNullOrEmpty(email)) 
            {
                new Claim(ClaimTypes.Email, email);
            }
            else
            {
                //handle error
            }
            claims.AddRange(userRoles.Select(role => new Claim(ClaimTypes.Role, role)));

            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddHours(12),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
