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
    public partial class ImageContentDataService : IImageContentDataService
    {
        private readonly string _connectionString;
        private readonly DapperTableMapper<ImageContent> _mapper;

        public ImageContentDataService(string connectionString)
        {
            _connectionString = connectionString;
            _mapper = new DapperTableMapper<ImageContent>(
                      SQLQueries.ImageContentTemplate,
                      MapToObject,
                      MapPropertyToParameter);
        }

        public void Create(ImageContent image)
        {
            throw new NotImplementedException();
        }

        public void Delete(ImageContent image)
        {
            throw new NotImplementedException();
        }

        public ImageContent Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<ImageContent> Get()
        {
            throw new NotImplementedException();
        }

        public void Update(ImageContent image)
        {
            throw new NotImplementedException();
        }
    }
}
