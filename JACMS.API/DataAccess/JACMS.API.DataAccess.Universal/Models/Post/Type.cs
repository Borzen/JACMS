using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.API.DataAccess.Core.Models.Post
{
    public class Type
    {
        public int TypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TemplateId { get; set; }
    }
}
