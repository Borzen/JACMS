using JACMS.Content.Core.DataServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Core.DataServices.Abstractions
{
    public interface IPageDataService
    {
        Page Get(int id);

        List<Page> Get(Expression<Func<Page, bool>> getExpression);

        void Create(Page page);

        void Update(Page page);

        void Delete(int id);
    }
}
