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
        public const string DocumentName = "DocumentName";
        public const string CreatedDateTime = "CreatedDateTime";
        public const string CreatedBy = "CreatedBy";
    }
    public class SQLQueries
    {
        public const string DocumentSelectTemplate = "Select * From Document";
    }
    public class SQLStoredProcedures
    {
        public const string DocumentCreateProcedure = "usp_Document_Create";
        public const string DocumentUpdateProcedure = "usp_Document_Update";
        public const string DocumentDeleteProcedure = "usp_Document_Delete";
        public const string DocumentUndeleteProdcedure = "usp_Document_UnDelete";
    }

}
