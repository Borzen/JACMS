using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Infrastructure.MariaDb.Constants
{
    public class SQLParamaters
    {
        public const string DocumentId = "DocumentId";
        public const string Name = "Name";
        public const string CreatedDateTime = "CreatedDateTime";
        public const string CreatedBy = "CreatedBy";
    }
    public class SQLQueries
    {
        public const string DocumentSelectTemplate = "Select * From Document";
    }
    public class SQLStoredProcedures
    {
        public const string DocumentCreateProcedure = "";
        public const string DocumentUpdateProcedure = "";
    }

}
