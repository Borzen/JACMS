using JACMS.Content.Core.DataServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Core.DataServices.Abstractions
{
    public interface ISectionDataService
    {
        Section Get(int id);
        List<Section> Get();
        void Create(Section section);
        void Update(Section section);
        void Delete(Section section);
    }
}
