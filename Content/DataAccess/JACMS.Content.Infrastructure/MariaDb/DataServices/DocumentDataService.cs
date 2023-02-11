using JACMS.Content.Core.DataServices.Abstractions;
using JACMS.Content.Core.DataServices.Models;
using JACMS.Content.Infrastructure.MariaDb.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;
using JACMS.Content.Infrastructure.MariaDb.Helpers;

namespace JACMS.Content.Infrastructure.MariaDb.DataServices
{
    public partial class DocumentDataService : IDocumentDataService
    {
        private readonly string _connectionString;
        private readonly DapperTableMapper<Document> _mapper;
        
        public DocumentDataService(string connectionString)
        {
            _connectionString = connectionString;
            _mapper = new DapperTableMapper<Document>(
              SQLQueries.DocumentSelectTemplate
            , MapParametersToProperties
            , MapPropertyToParameter);
        }

        public void Create(Document document)
        {
            DynamicParameters parameters = _mapper.CreateParamaterMap(document);
            using(var connection = new MySqlConnection(_connectionString))
            {
                MySqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    connection.Execute(SQLStoredProcedures.DocumentCreate, parameters, commandType: CommandType.StoredProcedure);
                }
                catch(Exception ex)
                {
                    transaction.Dispose();
                }
            }
        }

        public void Delete(Document document, bool unDelete = false)
        {
            DynamicParameters parameters = null;
            string function = "";
            if (unDelete)
            {
                parameters = _mapper.UndeleteParamaterMap(document);
                function = SQLStoredProcedures.DocumentUndelete;
            }
            else
            {
                parameters = _mapper.DeleteParamaterMap(document);
                function = SQLStoredProcedures.DocumentUndelete;
            }
            using (var connection = new MySqlConnection(_connectionString))
            {
                MySqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    connection.Execute(function, parameters, commandType: CommandType.StoredProcedure);
                }
                catch (Exception ex)
                {
                    transaction.Dispose();
                }
            }
        }

        public Document Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Document> Get()
        {
            throw new NotImplementedException();
        }
    }
}
