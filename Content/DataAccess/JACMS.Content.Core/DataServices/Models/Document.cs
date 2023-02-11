using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JACMS.Content.Core.DataServices.Models.Attributes;

namespace JACMS.Content.Core.DataServices.Models
{
    public class Document
    {
        [UpdateParam, DeleteParam, UndeleteParam]
        public int DocumentId { get; set; }
        [CreateParam]
        public string DocumentName { get; set; }
        [CreateParam]
        public DateTime CreatedDateTime { get; set; } = DateTime.UtcNow;
        [CreateParam]
        public int? CreatedBy { get; set; }
        [DeleteParam]
        public bool IsDeleted { get; set; }
        [DeleteParam]
        public int? DeletedBy { get; set; }
    }
}
