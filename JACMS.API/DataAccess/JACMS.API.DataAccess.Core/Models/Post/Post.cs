using JACMS.API.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.API.DataAccess.Core.Models.Post
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Excerpt { get; set; }
        public string Password { get; set; }
        public PostStatuses Status { get; set; }
        public DateTime? PostedDateTime { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public int ModifiedBy { get; set; }
        public string FQDN { get; set; }
        public Guid GUID { get; set; }
        public string Slug { get; set; }
        public string MIMEType { get; set; }
        public int MenuOrder { get; set; }
        public int? ParentId { get; set; }
        public int? TypeId { get; set; }
    }
}
