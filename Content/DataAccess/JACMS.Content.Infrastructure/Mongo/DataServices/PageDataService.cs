
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using JACMS.Content.Core.DataServices.Abstractions;
using JACMS.Content.Core.DataServices.Models;
using JACMS.Content.Core.Services.Abstractions;

namespace JACMS.Content.Infrastructure.Mongo.DataServices
{
    public class PageDataService : IPageDataService
    {
        private readonly IMongoService<Page> _mongoService;
        public PageDataService(IMongoService<Page> mongoService)
        {
            _mongoService = mongoService;
        }
        public void Create(Page page)
        {
            _mongoService.Create(page);
        }

        public Page Get(int id)
        {
            return _mongoService.Get(x => x.DocumentId == id.ToString());
        }
        public List<Page> Get(Expression<Func<Page, bool>> getExpression)
        {
            return _mongoService.Get(getExpression,false);
        }

        public void Update(Page page)
        {
            _mongoService.Update(x => x.DocumentId == page.DocumentId, page);
        }

        public void Delete(int id)
        {
            _mongoService.Delete(x=>x.DocumentId== id.ToString());
        }
    }
}
