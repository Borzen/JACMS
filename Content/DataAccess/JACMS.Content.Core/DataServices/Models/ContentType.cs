using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JACMS.Content.Core.DataServices.Models.Attributes;

namespace JACMS.Content.Core.DataServices.Models
{
    public class ContentType
    {
        public int ContentTypeId { get; set; }
        [CreateParam]
        public string ContentDescritpion { get; set; }
        [CreateParam]
        public string TableName { get; set; }
    }
}
