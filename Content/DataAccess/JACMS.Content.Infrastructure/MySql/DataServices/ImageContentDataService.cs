using JACMS.Content.Core.DataServices.Abstractions;
using JACMS.Content.Core.DataServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Infrastructure.MySql.DataServices
{
    public class ImageContentDataService : IImageContentDataService
    {
        private readonly string _connectionString;

        public ImageContentDataService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Create(ImageContent image)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
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
