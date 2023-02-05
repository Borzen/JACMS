using Dapper;
using JACMS.Content.Infrastructure.MySql.DataServices.Helpers.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Infrastructure.MariaDb.DataServices.Helpers
{
    internal class DapperTableMapper<T> : IDapperMapper<T>
    {
        private readonly string _baseSelectTemplate;
        private readonly string _createStoredProc;
        private readonly string _updateStoredProc;
        private readonly Func<dynamic, T> _mapperSwitch;
        private readonly Func<string, string> _paramaterSwitch;

        public string SelectStatement
        {
            get { return !string.IsNullOrEmpty(_baseSelectTemplate) ? _baseSelectTemplate : ""; }
        }
        public string CreateProc
        {
            get { return !string.IsNullOrEmpty(_createStoredProc) ? _createStoredProc : ""; }
        }
        public string UpdateProc
        {
            get { return !string.IsNullOrEmpty(_updateStoredProc) ? _updateStoredProc : ""; }
        }

        public DapperTableMapper(string baseSelectTemplate, string createStoredProc, string updateStoredProc, Func<dynamic, T> mapperSwitch, Func<string, string> paramaterSwitch)
        {
            _baseSelectTemplate = baseSelectTemplate;
            _createStoredProc = createStoredProc;
            _updateStoredProc = updateStoredProc;
            _mapperSwitch = mapperSwitch;
            _paramaterSwitch = paramaterSwitch;
        }

        public DynamicParameters CreateParamaterMap(T entity, bool isCreate = false, bool isUpdate = false)
        {
            if (!isCreate && !isUpdate)
                return null;
            DynamicParameters parameters = new DynamicParameters();
            var props = typeof(T).GetProperties();
            foreach(var prop in props)
            {
                var propName = _paramaterSwitch.Invoke(prop.Name);
                //handle if is create and to skip id field
                parameters.Add(propName, prop.GetValue(entity));
            }
            return parameters;
        }

        public string GenerateSQLStatement(IQueryable<T> sqlLinqExpression)
        {
            throw new NotImplementedException();
        }

        public T Map(dynamic sqlResults)
        {
            throw new NotImplementedException();
        }
    }
}
