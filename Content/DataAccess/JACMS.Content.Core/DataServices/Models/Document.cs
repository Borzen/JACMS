using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Core.DataServices.Models
{
    public class Document
    {
        public int DocumentId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.UtcNow;
        public int? CreatedBy { get; set; }

        //MultiReferences
        List<Section> Sections { get; set; }
    }
}
