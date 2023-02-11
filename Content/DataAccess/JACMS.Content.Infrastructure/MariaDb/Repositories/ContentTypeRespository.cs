using Dapper;
using JACMS.Content.Core.Repositories.Abstractions;
using MongoDB.Driver.Core.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Infrastructure.MariaDb.Repositories
{
    public class ContentTypeRespository : IContentTypeRepository
    {
        private readonly string _connectionString;
        public ContentTypeRespository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool ContentTypeExists(int id)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                string sqlTemplate = "select * from ContentType where ContentTypeId = {0}";
                dynamic results = connection.Query<dynamic>(string.Format(sqlTemplate, id)).ToList();
                if (results.Count > 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
