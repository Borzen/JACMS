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
    public partial class TextTypeDataService : ITextTypeDataService
    {
        private readonly string _connectionString;
        private readonly DapperTableMapper<TextType> _mapper;
        public TextTypeDataService(string connectionString)
        {
            _connectionString = connectionString;
            _mapper = new DapperTableMapper<TextType>(
                      SQLQueries.TextTypeTemplate,
                      MapToObject,
                      MapParamaterToProperty);
        }
        public void Create(TextType textType)
        {
            throw new NotImplementedException();
        }

        public void Delete(TextType textType)
        {
            throw new NotImplementedException();
        }

        public TextType Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<TextType> Get()
        {
            throw new NotImplementedException();
        }

        public void Update(TextType textType)
        {
            throw new NotImplementedException();
        }
    }
}
