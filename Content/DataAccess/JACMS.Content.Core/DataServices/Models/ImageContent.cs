using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JACMS.Content.Core.DataServices.Models.Attributes;


namespace JACMS.Content.Core.DataServices.Models
{
    public class ImageContent
    {
        [UpdateParam,DeleteParam,UndeleteParam]
        public int ImageContentId { get; set; }
        [CreateParam, UpdateParam]
        public string ImageName { get; set; }
        [CreateParam, UpdateParam]
        public string FileExtension { get; set; }
        [CreateParam]
        public Guid StorageName { get; set; }
        [CreateParam,UpdateParam,DeleteParam,UndeleteParam]
        public bool IsDeleted { get; set; }
        [CreateParam]
        public DateTime CreatedDateTime { get; set; } = DateTime.UtcNow;
        [CreateParam]
        public int? CreatedBy { get; set; } = null;
        [UpdateParam, DeleteParam, UndeleteParam]
        public DateTime ModifiedDateTime { get; set; } = DateTime.UtcNow;
        [UpdateParam, DeleteParam, UndeleteParam]
        public int? ModifiedBy { get; set; } = null;
        [CreateParam, UpdateParam]
        public string AltText { get; set; }
    }
}
