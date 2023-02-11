using JACMS.Content.Core.DataServices.Models;
using JACMS.Content.Infrastructure.MariaDb.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Infrastructure.MariaDb.DataServices
{
    public partial class TextTypeDataService
    {
        private string MapParamaterToProperty(string paramName)
        {
            switch(paramName)
            {
                case "TextTypeId":
                    return SQLParamaters.TextTypeId;
                case "TypeName":
                    return SQLParamaters.TypeName;
                case "TypeDescription":
                    return SQLParamaters.TypeDescription;
                case "Style":
                    return SQLParamaters.Style;
                default:
                    return "";
            }
        }
        private TextType MapToObject(dynamic results)
        {
            return new TextType();
        }
    }
}
