using JACMS.Content.Core.DataServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Core.DataServices.Abstractions
{
    public interface IContentTypeDataService
    {
        ContentType Get(int id);
        List<ContentType> Get();
        void Create(ContentType contentType);
        void Update(ContentType contentType);
        void Delete(ContentType contentType);
    }
}
