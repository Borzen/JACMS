using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.PageBuilder.Constants
{
    public class ConfigurationConstants
    {
        public static string MariaDBConnectionString = "mariaDbConnectionString";
        public static string MongoDBConnectionString = "mongoDbConnectionString";

        public static string MariaDBUserName = "Database:sqldbuser";
        public static string MariaDBPassword = "Database:sqldbpass";

        public static string MongoDBUserName = "Database:mongodbuser";
        public static string MongoDBPassword = "Database:mongodbpass";
        public static string MongoDatabase = "PageCacheSettings:MongoDbDatabase";
        public static string MongoPageCollection = "PageCacheSettings:MongoDbCollection";
    }
}
