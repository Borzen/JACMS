using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Core.Services.Abstractions
{
    public interface IMongoService<T>
    {
        dynamic Get(Expression<Func<T, bool>> getExpression, bool isSingle = true);
        void Create(T newObject);
        void Update(Expression<Func<T, bool>> updateExpression, T updateObject);
        void Delete(Expression<Func<T, bool>> deleteExpression);
    }
}
