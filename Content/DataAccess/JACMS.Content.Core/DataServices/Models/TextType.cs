using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JACMS.Content.Core.DataServices.Models.Attributes;

namespace JACMS.Content.Core.DataServices.Models
{
    public class TextType
    {
        [UpdateParam]
        public int TextTypeId { get; set; }
        [CreateParam, UpdateParam]
        public string TypeName { get; set; }
        [CreateParam, UpdateParam]
        public string TypeDescription { get; set; }
        [CreateParam, UpdateParam]
        public string Style { get; set; }
    }
}
