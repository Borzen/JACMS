using Dapper;
using JACMS.API.DataAccess.Core.Models.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace JACMS.API.DataAccess.Core.Models.Helpers.Identity
{
    public static class RoleHelper
    {
        public static DynamicParameters GetCreateDynamicParams(this Role role, char seperator = '@')
        {
            if (role == null)
            {
                return null;
            }

            DynamicParameters dynamicParams = new DynamicParameters();
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram("Name", seperator), role.Name);
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram("NormalizedName", seperator), role.NormalizedName);
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram("ConcurrencyStamp", seperator), role.ConcurrencyStamp);

            return dynamicParams;
        }

        public static DynamicParameters GetUpdateDynamicParams(this Role role, char seperator = '@')
        {
            if (role == null)
            {
                return null;
            }

            DynamicParameters dynamicParams = new DynamicParameters();
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram("Id", seperator), role.Id);
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram("RoleName", seperator), role.Name);
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram("NormalizedName", seperator), role.NormalizedName);
            dynamicParams.Add(ParamaterFormatterHelper.FormatPram("ConcurrencyStamp", seperator), role.ConcurrencyStamp);
            return dynamicParams;
        }
    }
}
