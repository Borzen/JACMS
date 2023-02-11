using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Core.Exceptions
{
    public class ContentExceptions
    {
        public static Func<(int, string)> TextTypeNotFound = () => (1000, "Text Type with Id {0} was not found and cannot create Text Conent");
        public static Func<(int, string)> DocumentNotFound = () => (1001, "Document with the Id {0} was not found and cannot create Section");
        public static Func<(int, string)> ContentTypeNotFound = () => (1002, "Content Type with the Id {0} was not found and cannot create Section");
            
    }
}
