using JACMS.Content.Core.DataServices.Models;
using JACMS.Content.Infrastructure.MariaDb.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Infrastructure.MariaDb.DataServices
{
    public partial class TextContentDataService
    {
        private string MapPropertyToParamater(string propertyName)
        {
            switch(propertyName)
            {
                case "TextContentId":
                    return SQLParamaters.TextContentId;
                case "TextValue":
                    return SQLParamaters.TextValue;
                case "TextTypeId":
                    return SQLParamaters.TextTypeId;
                case "IsDeleted":
                    return SQLParamaters.IsDeleted;
                case "CreatedDateTime":
                    return SQLParamaters.CreatedDateTime;
                case "CreatedBy":
                    return SQLParamaters.CreatedBy;
                case "ModifiedDateTime":
                    return SQLParamaters.ModifiedDateTime;
                case "ModifiedBy":
                    return SQLParamaters.ModifiedBy;
                default:
                    return "";
            }
        }
        private TextContent MapToObject(dynamic results)
        {
            return new TextContent();
        }
    }
}
