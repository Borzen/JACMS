using JACMS.Content.Core.DataServices.Models;
using JACMS.Content.Infrastructure.MariaDb.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Infrastructure.MariaDb.DataServices
{
    public partial class DocumentDataService
    {

        private string MapPropertyToParameter(string propertyName)
        {
            switch(propertyName)
            {
                case "DocumentId":
                    return SQLParamaters.DocumentId;
                case "Name":
                    return SQLParamaters.DocumentName;
                case "CreatedDateTime":
                    return SQLParamaters.CreatedDateTime;
                case "CreatedBy":
                    return SQLParamaters.CreatedBy;
                case "IsDeleted":
                    return SQLParamaters.IsDeleted;
                case "DeletedBy":
                    return SQLParamaters.DeletedBy;
                default:
                    return "";
            }
        }

        private Document MapParametersToProperties(dynamic results)
        {
            return new Document();
        }
    }
}
