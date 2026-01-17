using Dapper;
using JACMS.API.DataAccess.Core.Models.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace JACMS.API.DataAccess.PostgreSQL.Helpers.Identity
{
    public static class UserHelpers
    {
        public static new DynamicParameters GetCreateDynamicParams(this User user)
        {
            if(user == null)
            {
                return null;
            }

            DynamicParameters dynamicParams = new DynamicParameters();

            dynamicParams.Add("UserName", user.UserName);
            dynamicParams.Add("NormalizedUserName", user.NormalizedUserName);
            dynamicParams.Add("Email", user.Email);
            dynamicParams.Add("NormalizedEmail", user.NormalizedEmail);
            dynamicParams.Add("EmailConfirmed", user.EmailConfirmed);
            dynamicParams.Add("PasswordHash", user.PasswordHash);
            dynamicParams.Add("SecurityStamp", user.SecurityStamp);
            dynamicParams.Add("ConcurrencyStamp", user.ConcurrencyStamp);
            dynamicParams.Add("PhoneNumber", user.PhoneNumber);
            dynamicParams.Add("PhoneNumberConfirmed", user.PhoneNumberConfirmed);
            dynamicParams.Add("TwoFactorEnabled", user.TwoFactorEnabled);
            dynamicParams.Add("LockoutEnd", user.LockoutEnd);
            dynamicParams.Add("LockoutEnabled", user.LockoutEnabled);
            dynamicParams.Add("AccessFailedCount", user.AccessFailedCount);

            return dynamicParams;
        }
    }
}
