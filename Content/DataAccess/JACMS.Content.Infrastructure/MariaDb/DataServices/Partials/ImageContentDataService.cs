using JACMS.Content.Core.DataServices.Models;
using JACMS.Content.Infrastructure.MariaDb.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Infrastructure.MariaDb.DataServices
{
    public partial class ImageContentDataService
    {
        private string MapPropertyToParameter(string propertyName)
        { 
            switch(propertyName) 
            {
                case "ImageContentId":
                    return SQLParamaters.ImageContentId;
                case "ImageName":
                    return SQLParamaters.ImageName;
                case "FileExtension":
                    return SQLParamaters.FileExtension;
                case "StorageName":
                    return SQLParamaters.StorageName;
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
                case "AltText":
                    return SQLParamaters.AltText;
                default:
                    return "";
            }
        }
        private ImageContent MapToObject(dynamic results)
        {
            return new ImageContent();
        }
    }
}
