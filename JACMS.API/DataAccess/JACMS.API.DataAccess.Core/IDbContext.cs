using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.API.DataAccess.Core
{
    public interface IDbContext : IDisposable
    {
        public IDbConnection GetDbConnection();
    }
}
