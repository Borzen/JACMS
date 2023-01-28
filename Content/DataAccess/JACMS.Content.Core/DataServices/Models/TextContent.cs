using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Core.DataServices.Models
{
    public class TextContent
    {
        public int TextContentId { get; set; }
        public string Value { get; set; }
        public int TextTypeId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.UtcNow;
        public DateTime ModifiedDateTime { get; set; } = DateTime.UtcNow;
    }
}
