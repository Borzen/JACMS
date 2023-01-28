using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Core.DataServices.Models
{
    public class Section
    {
        public int SectionId { get; set; }
        public string Name { get; set; }
        public int DocumentId { get; set; }
        public int TypeId { get; set; }
        public int ContentId { get; set; }
        public bool IsDeleted { get; set; }
        public int order { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.UtcNow;
        public int? CreatedBy { get; set; }
    }
}
