using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Core.DataServices.Models
{
    public class Page
    {
        public int Id { get; set; }
        public string PageContent { get; set; }
        public string DocumentId { get; set; }
        public string DocumentTitle { get; set; }
    }
}
