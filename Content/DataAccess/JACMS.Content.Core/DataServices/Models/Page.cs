using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JACMS.Content.Core.DataServices.Models.Attributes;


namespace JACMS.Content.Core.DataServices.Models
{
    public class Page
    {
        [UpdateParam,DeleteParam]
        public int Id { get; set; }
        [CreateParam,UpdateParam]
        public string PageContent { get; set; }
        [CreateParam,UpdateParam,DeleteParam]
        public string DocumentId { get; set; }
        [CreateParam,UpdateParam]
        public string DocumentTitle { get; set; }
    }
}
