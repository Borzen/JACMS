using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JACMS.API.Core.Models.Requests.User
{
    public class UserCreationRequest
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public string PhoneNumber { get; set; } = "";
        public List<dynamic> Roles { get; set; } = new List<dynamic>();
    }
}
