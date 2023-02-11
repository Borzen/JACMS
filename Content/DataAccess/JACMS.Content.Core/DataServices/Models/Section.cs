using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JACMS.Content.Core.DataServices.Models.Attributes;

namespace JACMS.Content.Core.DataServices.Models
{
    public class Section
    {
        [UpdateParam, DeleteParam, UndeleteParam]
        public int SectionId { get; set; }
        [CreateParam,UpdateParam]
        public string SectionName { get; set; }
        [CreateParam]
        public int DocumentId { get; set; }
        [CreateParam, UpdateParam]
        public int TypeId { get; set; }
        [CreateParam,UpdateParam]
        public int ContentId { get; set; }
        [DeleteParam, UndeleteParam]
        public bool IsDeleted { get; set; }
        [CreateParam, UpdateParam]
        public int SectionOrder { get; set; }
        [CreateParam]
        public DateTime CreatedDateTime { get; set; } = DateTime.UtcNow;
        [CreateParam]
        public int? CreatedBy { get; set; } = null;
        [UpdateParam, DeleteParam, UndeleteParam]
        public DateTime? ModifiedDateTime { get; set; } = DateTime.UtcNow;
        [UpdateParam, DeleteParam, UndeleteParam]
        public int? ModifiedBy { get; set; } = null;
    }
}
