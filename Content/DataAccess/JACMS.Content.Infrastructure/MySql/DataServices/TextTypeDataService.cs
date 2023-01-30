using JACMS.Content.Core.DataServices.Abstractions;
using JACMS.Content.Core.DataServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Infrastructure.MySql.DataServices
{
    public class TextTypeDataService : ITextTypeDataService
    {
        private readonly string _connectionString;
        public TextTypeDataService(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void Create(TextType textType)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
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
