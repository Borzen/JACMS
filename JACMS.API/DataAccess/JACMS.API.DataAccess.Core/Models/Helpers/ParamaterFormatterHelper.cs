using System;
using System.Collections.Generic;
using System.Text;

namespace JACMS.API.DataAccess.Core.Models.Helpers
{
    internal static class ParamaterFormatterHelper
    {
        internal static string FormatPram(string paramName, char seperator)
        {
            return $"{seperator}{paramName}";
        }

        internal static string FormatPram(string paramName, char seperator, bool useSnakeCase)
        {
            if (useSnakeCase)
            {
                var snakeCaseParam = ToSnakeCase(paramName);
                return $"{seperator}{snakeCaseParam}";
            }
            else
            {
                return $"{seperator}{paramName}";
            }
        }

        private static string ToSnakeCase(this string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }
            if (text.Length < 2)
            {
                return text.ToLowerInvariant();
            }
            var sb = new StringBuilder();
            sb.Append(char.ToLowerInvariant(text[0]));
            for (int i = 1; i < text.Length; ++i)
            {
                char c = text[i];
                if (char.IsUpper(c))
                {
                    sb.Append('_');
                    sb.Append(char.ToLowerInvariant(c));
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}
