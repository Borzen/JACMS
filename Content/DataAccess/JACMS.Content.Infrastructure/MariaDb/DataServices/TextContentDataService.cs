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
    public partial class TextContentDataService : ITextContentDataService
    {
        private readonly string _connectionString;
        private readonly DapperTableMapper<TextContent> _mapper;

        public TextContentDataService(string connectionString)
        {
            _connectionString = connectionString;
            _mapper = new DapperTableMapper<TextContent>(
                      SQLQueries.TextContentTemplate,
                      MapToObject,
                      MapPropertyToParamater);
        }
        public void Create(TextContent content)
        {
            throw new NotImplementedException();
        }

        public void Delete(TextContent content)
        {
            throw new NotImplementedException();
        }

        public TextContent Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<TextContent> Get()
        {
            throw new NotImplementedException();
        }

        public void Update(TextContent content)
        {
            throw new NotImplementedException();
        }
    }
}
