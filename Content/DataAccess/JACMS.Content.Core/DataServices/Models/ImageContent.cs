using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Core.DataServices.Models
{
    public class ImageContent
    {
        public int ImageContentId { get; set; }
        public string Name { get; set; }
        public string FileExtension { get; set; }
        public Guid Storagename { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.UtcNow;
        public DateTime ModifiedDateTime { get; set; } = DateTime.UtcNow;
        public string AltText { get; set; }
    }
}
