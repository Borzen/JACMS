using JACMS.Content.Core.DataServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Core.DataServices.Abstractions
{
    public interface IDocumentDataService
    {
        Document Get(int id);
        List<Document> Get();
        void Create(Document document);
        void Delete(Document document, bool unDelete = false);
    }
}
