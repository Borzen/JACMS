using JACMS.Content.Core.DataServices.Abstractions;
using JACMS.Content.Core.DataServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Infrastructure.MariaDb.DataServices
{
    public class SectionDataService : ISectionDataService
    {
        private readonly string _connectionString;
        public SectionDataService(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void Create(Section section)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Section Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Section> Get()
        {
            throw new NotImplementedException();
        }

        public void Update(Section section)
        {
            throw new NotImplementedException();
        }
    }
}
