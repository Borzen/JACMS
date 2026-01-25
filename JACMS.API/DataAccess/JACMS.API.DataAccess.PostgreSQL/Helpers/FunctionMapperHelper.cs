using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace JACMS.API.DataAccess.PostgreSQL.Helpers
{
    internal class FunctionMapperHelper
    {
        public static string GenerateFunctionStatement(string functionName, DynamicParameters dynamicParams)
        {
            var functionCallBuilder = new StringBuilder($"Select * from {functionName} (");
            var paramNames = GenerateListOfPrams(dynamicParams);
            functionCallBuilder.Append(string.Join(",", paramNames));
            functionCallBuilder.Append(")");
            return functionCallBuilder.ToString();
        }

        private static List<string> GenerateListOfPrams(DynamicParameters dynamicParams)
        {
            var paramNames = new List<string>();
            foreach (var paramName in dynamicParams.ParameterNames)
            {
                paramNames.Add($":{paramName}");
            };
            return paramNames;
        }
    }
}
