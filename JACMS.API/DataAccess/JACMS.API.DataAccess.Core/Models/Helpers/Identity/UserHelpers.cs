using Dapper;
using JACMS.API.DataAccess.Core.Models.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace JACMS.API.DataAccess.Core.Models.Helpers.Identity
{
    public static class UserHelpers
    {
        public static DynamicParameters GetCreateDynamicParams(this User user, char seperator = '@', bool useSnakeCase = false)
        {
            if(user == null)
            {
                return null;
            }

            DynamicParameters dynamicParams = new DynamicParameters();

            dynamicParams.Add(ParamaterFormatterHelper.FormatPram($"UserName",seperator,useSnakeCase), user.UserName);
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram($"NormalizedUserName",seperator,useSnakeCase), user.NormalizedUserName);
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram($"Email",seperator,useSnakeCase), user.Email);
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram($"NormalizedEmail",seperator,useSnakeCase), user.NormalizedEmail);
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram($"EmailConfirmed",seperator,useSnakeCase), user.EmailConfirmed);
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram($"PasswordHash",seperator,useSnakeCase), user.PasswordHash);
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram($"SecurityStamp",seperator,useSnakeCase), user.SecurityStamp, System.Data.DbType.String);
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram($"ConcurrencyStamp",seperator,useSnakeCase), user.ConcurrencyStamp, System.Data.DbType.String);
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram($"PhoneNumber",seperator,useSnakeCase), user.PhoneNumber, System.Data.DbType.String);
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram($"PhoneNumberConfirmed",seperator,useSnakeCase), user.PhoneNumberConfirmed);
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram($"TwoFactorEnabled",seperator,useSnakeCase), user.TwoFactorEnabled);
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram($"LockoutEnd",seperator,useSnakeCase), user.LockoutEnd, System.Data.DbType.DateTimeOffset);
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram($"LockoutEnabled",seperator,useSnakeCase), user.LockoutEnabled);
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram($"AccessFailedCount",seperator,useSnakeCase), user.AccessFailedCount);

            return dynamicParams;
        }
    }
}
