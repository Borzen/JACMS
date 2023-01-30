using JACMS.Content.Core.DataServices.Abstractions;
using JACMS.Content.Core.DataServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Infrastructure.MySql.DataServices
{
    public class DocumentDataService : IDocumentDataService
    {
        private readonly string _connectionString;
        
        public DocumentDataService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Create(Document document)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Document Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Document> Get()
        {
            throw new NotImplementedException();
        }

        public void Update(Document document)
        {
            throw new NotImplementedException();
        }
    }
}
