using JACMS.Content.Core.Commands.ReturnTypes.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Core.Commands.ReturnTypes
{
    public class IntReturn : ReturnType<int>
    {
        public IntReturn() { }
        public IntReturn(int value) 
        { 
            Value = value;
            IsSuccessful= true;
        }
        public IntReturn((int,string) errorMessage)
        {
            IsSuccessful = false;
            ErrorMessage = errorMessage;
        }
    }
}
