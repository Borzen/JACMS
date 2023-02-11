using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.APIClient.Models.Requests
{
    public class ImageContentCreateRequest
    {
        public string ImageName { get; set; }
        public string FileExtension { get; set; }
        public byte[] Data { get; set; }
    }
}
