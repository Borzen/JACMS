using Dapper;
using JACMS.API.DataAccess.Core.Models.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace JACMS.API.DataAccess.Core.Models.Helpers.Identity
{
    public static class UserRoleHelper
    {
        public static DynamicParameters GetCreateUserRoleDynamicParams(this User user, long roleId, char seperator = '@')
        {
            if (user == null)
            {
                return null;
            }

            DynamicParameters dynamicParams = new DynamicParameters();
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram("UserId", seperator), user.Id);
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram("RoleId", seperator), roleId);

            return dynamicParams;
        }
    }
}
