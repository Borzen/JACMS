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
    public partial class SectionDataService : ISectionDataService
    {
        private readonly string _connectionString;
        private readonly DapperTableMapper<Section> _mapper;
        public SectionDataService(string connectionString)
        {
            _connectionString = connectionString;
            _mapper = new DapperTableMapper<Section>(
                      SQLQueries.SectionTemplate,
                      MapToObject,
                      MapPropertiesToParamaters);
        }
        public void Create(Section section)
        {
            throw new NotImplementedException();
        }

        public void Delete(Section section)
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
