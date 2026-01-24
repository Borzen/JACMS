using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.API.DataAccess.Core.Configurations
{
    public class DBConfig
    {
        public const string ConfigurationSection = "DBConfig";

        public string Provider { get; set; }
        public string ConnectionString { get; set; }
    }
}
