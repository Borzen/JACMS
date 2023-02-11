using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Core.Repositories.Abstractions
{
    public interface IDocumentRepository
    {
        bool DocumentExists(int id);
    }
}
