using JACMS.Content.Core.DataServices.Models;
using JACMS.Content.Infrastructure.MariaDb.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Infrastructure.MariaDb.DataServices
{
    public partial class ContentTypeDataService
    {
        private string MapPropertyToParameter(string propertyName)
        {
            switch(propertyName)
            {
                case "ContentTypeId":
                    return SQLParamaters.ContentTypeId;
                case "ContentDescritpion":
                    return SQLParamaters.ContentDescritpion;
                case "TableName":
                    return SQLParamaters.TableName;
                default:
                    return "";
            }
        }

        private ContentType MapToObject(dynamic results)
        {
            return new ContentType();
        }
    }
}
