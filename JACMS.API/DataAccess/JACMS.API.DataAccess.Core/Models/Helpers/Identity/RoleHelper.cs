using Dapper;
using JACMS.API.DataAccess.Core.Models.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace JACMS.API.DataAccess.Core.Models.Helpers.Identity
{
    public static class RoleHelper
    {
        public static DynamicParameters GetCreateDynamicParams(this Role role)
        {
            if(role == null)
            {
                return null;
            }

            DynamicParameters dynamicParams = new DynamicParameters();
            dynamicParams.Add("@Name", role.Name);
            dynamicParams.Add("@NormalizedName", role.NormalizedName);
            dynamicParams.Add("@ConcurrencyStamp", role.ConcurrencyStamp);

            return dynamicParams;
        }
    }
}
