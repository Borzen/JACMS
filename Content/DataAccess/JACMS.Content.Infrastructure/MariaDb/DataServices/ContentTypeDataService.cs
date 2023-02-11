using JACMS.Content.Core.DataServices.Abstractions;
using JACMS.Content.Core.DataServices.Models;
using JACMS.Content.Infrastructure.MariaDb.Constants;
using JACMS.Content.Infrastructure.MariaDb.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Infrastructure.MariaDb.DataServices
{
    public partial class ContentTypeDataService : IContentTypeDataService
    {
        private readonly string _connectionString;
        private readonly DapperTableMapper<ContentType> _mapper;
        public ContentTypeDataService(string connectionString)
        {
            _connectionString = connectionString;
            _mapper = new DapperTableMapper<ContentType>(
                      SQLQueries.ContentTypeTemplate,
                      MapToObject,
                      MapPropertyToParameter
                      );
        }
        public void Create(ContentType contentType)
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
    }
}
