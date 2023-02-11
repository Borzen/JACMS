using JACMS.Content.Core.DataServices.Models;
using JACMS.Content.Infrastructure.MariaDb.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Infrastructure.MariaDb.DataServices
{
    public partial class SectionDataService
    {
        private string MapPropertiesToParamaters(string propertyName)
        {
            switch(propertyName)
            {
                case "SectionId":
                    return SQLParamaters.SectionId;
                case "SectionName":
                    return SQLParamaters.SectionName;
                case "DocumentId":
                    return SQLParamaters.DocumentId;
                case "ContentTypeId":
                    return SQLParamaters.ContentTypeId;
                case "ContentId":
                    return SQLParamaters.ContentId;
                case "IsDeleted":
                    return SQLParamaters.IsDeleted;
                case "SectionOrder":
                    return SQLParamaters.SectionOrder;
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

        private Section MapToObject(dynamic results)
        {
            return new Section();
        }
    }
}
