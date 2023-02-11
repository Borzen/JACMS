using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Infrastructure.MariaDb.Helpers.Abstraction
{
    internal interface IDapperMapper<T>
    {
        DynamicParameters CreateParamaterMap(T entity);
        DynamicParameters UpdateParamaterMap(T entity);
        DynamicParameters DeleteParamaterMap(T entity);
        DynamicParameters UndeleteParamaterMap(T entity);
        string GenerateSQLStatement(IQueryable<T> sqlLinqExpression);
        T Map(dynamic sqlResults);
    }
}
