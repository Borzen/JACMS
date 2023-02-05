using JACMS.Content.Core.DataServices.Abstractions;
using JACMS.Content.Core.DataServices.Models;
using JACMS.Content.Infrastructure.MariaDb.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using JACMS.Content.Infrastructure.MariaDb.DataServices.Helpers;
using Dapper;
using MySql.Data.MySqlClient;

namespace JACMS.Content.Infrastructure.MariaDb.DataServices
{
    public partial class DocumentDataService : IDocumentDataService
    {
        private readonly string _connectionString;
        private readonly DapperTableMapper<Document> _mapper;
        
        public DocumentDataService(string connectionString)
        {
            _connectionString = connectionString;
            _mapper = new DapperTableMapper<Document>(SQLQueries.DocumentSelectTemplate
            , SQLStoredProcedures.DocumentCreateProcedure
            , SQLStoredProcedures.DocumentUpdateProcedure
            , MapParametersToProperties
            , MapPropertyToParameter);
        }

        public void Create(Document document)
        {
            DynamicParameters parameters = _mapper.CreateParamaterMap(document,isCreate: true);
            using(var connection = new MySqlConnection(_connectionString))
            {
                MySqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    connection.Execute(_mapper.CreateProc, parameters, commandType: CommandType.StoredProcedure);
                }
                catch(Exception ex)
                {
                    transaction.Dispose();
                }
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Document Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Document> Get()
        {
            throw new NotImplementedException();
        }

        public void Update(Document document)
        {
            throw new NotImplementedException();
        }
    }
}
