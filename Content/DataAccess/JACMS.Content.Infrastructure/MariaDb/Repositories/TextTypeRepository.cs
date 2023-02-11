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
    public class TextTypeRepository : ITextTypeRepository
    {
        private readonly string _connectionString;
        public TextTypeRepository(string connectionString)
        {
            _connectionString= connectionString;
        }
        public bool TextTypeExists(int id)
        {
            using(var connection = new MySqlConnection(_connectionString))
            {
                string sqlTemplate = "select * from TextType where TextTypeId = {0}";
                dynamic results = connection.Query<dynamic>(string.Format(sqlTemplate, id)).ToList();
                if(results.Count > 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
