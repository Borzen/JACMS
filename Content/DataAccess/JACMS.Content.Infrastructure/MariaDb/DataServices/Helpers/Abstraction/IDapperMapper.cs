using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Infrastructure.MariaDb.DataServices.Helpers.Abstraction
{
    internal interface IDapperMapper<T>
    {
        DynamicParameters CreateParamaterMap(T entity, bool isCreate = false, bool isUpdate = false);

        string GenerateSQLStatement(IQueryable<T> sqlLinqExpression);

        T Map(dynamic sqlResults);
    }
}
