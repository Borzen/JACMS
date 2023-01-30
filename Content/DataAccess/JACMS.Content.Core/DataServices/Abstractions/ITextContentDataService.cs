using JACMS.Content.Core.DataServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Core.DataServices.Abstractions
{
    public interface ITextContentDataService
    {
        TextContent Get(int id);
        List<TextContent> Get();
        void Create(TextContent content);
        void Update(TextContent content);
        void Delete(int id);
    }
}
