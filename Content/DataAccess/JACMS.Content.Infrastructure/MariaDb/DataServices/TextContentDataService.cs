using JACMS.Content.Core.DataServices.Abstractions;
using JACMS.Content.Core.DataServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Infrastructure.MariaDb.DataServices
{
    public class TextContentDataService : ITextContentDataService
    {
        private readonly string _connectionString;

        public TextContentDataService(string connectionString)
        {
            _connectionString = connectionString;
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
