using JACMS.Content.Core.DataServices.Abstractions;
using JACMS.Content.Core.DataServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Infrastructure.MySql.DataServices
{
    public class ContentTypeDataService : IContentTypeDataService
    {
        private readonly string _connectionString;
        public ContentTypeDataService(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void Create(ContentType contentType)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ContentType Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContentType> Get()
        {
            throw new NotImplementedException();
        }

        public void Update(ContentType contentType)
        {
            throw new NotImplementedException();
        }
    }
}
