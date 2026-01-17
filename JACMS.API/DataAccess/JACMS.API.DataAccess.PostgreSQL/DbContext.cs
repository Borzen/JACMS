using JACMS.API.DataAccess.Core;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.API.DataAccess.PostgreSQL
{
    internal class DbContext : IDbContext, IDisposable
    {
        private readonly string _connectionString;
        private IDbConnection _dbConnection;

        public DbContext(string connectionString)
        { 
            _connectionString = connectionString;
        }

        public void Dispose()
        {
            if (_dbConnection != null && _dbConnection.State == ConnectionState.Open)
            {
                _dbConnection.Close();
                _dbConnection.Dispose();
            }
        }

        public IDbConnection GetDbConnection()
        {
            if (_dbConnection == null || _dbConnection.State != ConnectionState.Open)
            {
                _dbConnection = new NpgsqlConnection(_connectionString);
                _dbConnection.Open();
            }
            return _dbConnection;
        }
    }
}
