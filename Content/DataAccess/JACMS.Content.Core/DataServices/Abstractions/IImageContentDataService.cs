using JACMS.Content.Core.DataServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Core.DataServices.Abstractions
{
    public interface IImageContentDataService
    {
        ImageContent Get(int id);
        List<ImageContent> Get();
        void Create(ImageContent image);
        void Update(ImageContent image);
        void Delete(ImageContent image);
    }
}
