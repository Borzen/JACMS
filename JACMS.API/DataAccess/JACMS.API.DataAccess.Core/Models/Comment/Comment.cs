using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.API.DataAccess.Core.Models.Comment
{
    public class Comment
    {
        public int CommentId { get; set; }
        public int PostId { get; set; }
        public string PostersIP { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int CreatedBy { get; set; }
        public string Content { get; set; }
        public bool Approved { get; set; }
        public int ParentId { get; set; }
    }
}
