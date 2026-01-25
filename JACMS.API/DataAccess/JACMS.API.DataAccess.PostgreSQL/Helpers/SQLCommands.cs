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
                public const string Update = "\"Identity\".user_update";
                public const string Delete = "\"Identity\".user_delete";
                public const string Get = "\"Identity\".user_get_all_valid_users";
                public const string GetByNormalizedName = "\"Identity\".user_get_all_valid_users_by_normalized_name";
                public const string GetById = "\"Identity\".user_get_all_valid_users_by_id";
            }

            internal static class Role
            {
                public const string Create = "\"Identity\".role_create";
                public const string Update = "\"Identity\".role_update";
                public const string Delete = "\"Identity\".role_delete";
                public const string Get = "\"Identity\".role_get_all_valid_roles";
                public const string GetByNormalizedName = "\"Identity\".role_get_all_valid_roles_by_normalized_name";
                public const string GetByName = "\"Identity\".role_get_all_valid_roles_by_name";
                public const string GetById = "\"Identity\".role_get_all_valid_roles_by_id";

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
