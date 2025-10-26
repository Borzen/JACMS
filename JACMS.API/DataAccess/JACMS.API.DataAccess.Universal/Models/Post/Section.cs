using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.API.DataAccess.Core.Models.Post
{
    public class Section 
    {
        public int SectionId { get; set; }
        public string Content { get; set; }
        public string Tag { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public int ModifiedBy { get; set; }
        public dynamic Type { get; set; }
    }
}
