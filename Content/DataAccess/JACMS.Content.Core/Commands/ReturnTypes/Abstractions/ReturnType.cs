using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Core.Commands.ReturnTypes.Abstractions
{
    public class ReturnType<T>
    {
        public T Value { get; set; }
        public bool IsSuccessful { get; set; }
        public (int,string) ErrorMessage { get; set; }
    }
}
