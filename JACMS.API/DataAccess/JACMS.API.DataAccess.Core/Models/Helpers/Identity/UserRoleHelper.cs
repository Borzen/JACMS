using Dapper;
using JACMS.API.DataAccess.Core.Models.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace JACMS.API.DataAccess.Core.Models.Helpers.Identity
{
    public static class UserRoleHelper
    {
        public static DynamicParameters GetCreateUserRoleDynamicParams(this User user, long roleId)
        {
            if (user == null)
            {
                return null;
            }

            DynamicParameters dynamicParams = new DynamicParameters();
            dynamicParams.Add("@UserId", user.Id);
            dynamicParams.Add("@RoleId", roleId);

            return dynamicParams;
        }
    }
}
