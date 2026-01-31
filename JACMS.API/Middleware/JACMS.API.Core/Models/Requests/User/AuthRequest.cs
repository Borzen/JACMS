using System;
using System.Collections.Generic;
using System.Text;

namespace JACMS.API.Core.Models.Requests.User
{
    public class AuthRequest
    {
        /// <summary>
        /// This gets or sets the username used for a signin request (if username is the displayed unique identifier).
        /// </summary>
        public string? UserName { get; set; } = "";

        /// <summary>
        /// This gets or sets the email address used for a signin request (if email is the displayed unique identifier).
        /// </summary>
        public string? Email { get; set; } = "";

        /// <summary>
        /// This gets or sets the password used for the signin request. 
        /// </summary>
        public string Password { get; set; }
    }
}
