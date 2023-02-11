using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.APIClient.Models.Requests
{
    public class SectionCreateRequest
    {
        public string SectionName { get; }
        public int DocumentId { get; }
        public int ContentTypeId { get; }
        public int ContentId { get; }
        public int SectionOrder { get; }

       
    }
}
