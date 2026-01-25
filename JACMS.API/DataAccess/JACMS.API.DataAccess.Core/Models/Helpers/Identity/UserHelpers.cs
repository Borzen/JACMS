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
        public static DynamicParameters GetCreateDynamicParams(this User user, char seperator = '@')
        {
            if(user == null)
            {
                return null;
            }

            DynamicParameters dynamicParams = new DynamicParameters();

            dynamicParams.Add(ParamaterFormatterHelper.FormatPram($"UserName",seperator), user.UserName);
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram($"NormalizedUserName",seperator), user.NormalizedUserName);
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram($"Email",seperator), user.Email);
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram($"NormalizedEmail",seperator), user.NormalizedEmail);
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram($"EmailConfirmed",seperator), user.EmailConfirmed);
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram($"PasswordHash",seperator), user.PasswordHash);
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram($"SecurityStamp",seperator), user.SecurityStamp, System.Data.DbType.String);
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram($"ConcurrencyStamp",seperator), user.ConcurrencyStamp, System.Data.DbType.String);
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram($"PhoneNumber",seperator), user.PhoneNumber, System.Data.DbType.String);
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram($"PhoneNumberConfirmed",seperator), user.PhoneNumberConfirmed);
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram($"TwoFactorEnabled",seperator), user.TwoFactorEnabled);
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram($"LockoutEnd",seperator), user.LockoutEnd, System.Data.DbType.DateTimeOffset);
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram($"LockoutEnabled",seperator), user.LockoutEnabled);
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram($"AccessFailedCount",seperator), user.AccessFailedCount);

            return dynamicParams;
        }
    }
}
