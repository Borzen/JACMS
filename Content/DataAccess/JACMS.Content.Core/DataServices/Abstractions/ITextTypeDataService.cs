using JACMS.Content.Core.DataServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Core.DataServices.Abstractions
{
    public interface ITextTypeDataService
    {
        TextType Get(int id);
        List<TextType> Get();
        void Create(TextType textType);
        void Update(TextType textType);
        void Delete(TextType id);

    }
}
