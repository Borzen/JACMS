using Dapper;
using JACMS.Content.Core.Repositories.Abstractions;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Infrastructure.MariaDb.Repositories
{
    public class DocumentRepository : IDocumentRepository
    {
        private readonly string _connectionString;
        public DocumentRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool DocumentExists(int id)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                string sqlTemplate = "select * from Document where DocumentId = {0}";
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
