using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.API.DataAccess.PostgreSQL.Helpers
{
    internal static class SQLCommands
    {
        internal static class Post
        {

            internal static class ExtendedData
            {

            }
        }
        internal static class Section
        {

        }
        internal static class Content
        {

        }
        internal static class PostType
        {

        }
        internal static class Template
        {

        }

        internal static class Identity
        {
            internal static class User
            {
                public const string Create = "\"Identity\".user_create";
            }

            internal static class Role
            {
                public const string Create = "\"Identity\".role_create";
                public const string GetByNormalizedName = "Select * from \"Identity\".Role where NormalizedName = @NormalizedName";
            }

            internal static class UserRole
            {
                public const string Create = "\"Identity\".userrole_create";
            }
        }

        internal static class Comment
        {
            internal static class ExtendedData
            {

            }
        }

    }
}
