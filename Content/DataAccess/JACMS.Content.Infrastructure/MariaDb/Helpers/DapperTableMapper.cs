using Dapper;
using JACMS.Content.Core.DataServices.Models.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JACMS.Content.Infrastructure.MariaDb.Helpers.Abstraction;

namespace JACMS.Content.Infrastructure.MariaDb.Helpers
{
    internal class DapperTableMapper<T> : IDapperMapper<T>
    {
        private readonly string _baseSelectTemplate;
        private readonly Func<dynamic, T> _mapperSwitch;
        private readonly Func<string, string> _paramaterMapper;

        public string SelectStatement
        {
            get { return !string.IsNullOrEmpty(_baseSelectTemplate) ? _baseSelectTemplate : ""; }
        }

        public DapperTableMapper(string baseSelectTemplate
                                , Func<dynamic, T> mapperSwitch
                                , Func<string, string> paramaterMapper)
        {
            _baseSelectTemplate = baseSelectTemplate;
            _mapperSwitch = mapperSwitch;
            _paramaterMapper = paramaterMapper;
        }

        public DynamicParameters CreateParamaterMap(T entity)
        {
            DynamicParameters parameters = new DynamicParameters();
            var props = typeof(T).GetProperties().Where(x => x.IsDefined(typeof(CreateParam), false));
            foreach (var prop in props)
            {
                var propName = _paramaterMapper.Invoke(prop.Name);
                parameters.Add(propName, prop.GetValue(entity));
            }
            return parameters;
        }

        public DynamicParameters UpdateParamaterMap(T entity)
        {
            DynamicParameters parameters = new DynamicParameters();
            var props = typeof(T).GetProperties().Where(x => x.IsDefined(typeof(UpdateParam), false));
            foreach (var prop in props)
            {
                var propName = _paramaterMapper.Invoke(prop.Name);
                parameters.Add(propName, prop.GetValue(entity));
            }
            return parameters;
        }
        public DynamicParameters DeleteParamaterMap(T entity)
        {
            DynamicParameters parameters = new DynamicParameters();
            var props = typeof(T).GetProperties().Where(x => x.IsDefined(typeof(DeleteParam), false));
            foreach (var prop in props)
            {
                var propName = _paramaterMapper.Invoke(prop.Name);
                parameters.Add(propName, prop.GetValue(entity));
            }
            return parameters;
        }
        public DynamicParameters UndeleteParamaterMap(T entity)
        {
            DynamicParameters parameters = new DynamicParameters();
            var props = typeof(T).GetProperties().Where(x => x.IsDefined(typeof(UndeleteParam), false));
            foreach (var prop in props)
            {
                var propName = _paramaterMapper.Invoke(prop.Name);
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
