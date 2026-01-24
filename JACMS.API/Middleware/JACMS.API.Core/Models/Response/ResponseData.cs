using System;
using System.Collections.Generic;
using System.Text;

namespace JACMS.API.Core.Models.Response
{
    public class ResponseData<T> : ResponseData
    {
        public T Data { get; set; }
    }

    public class ResponseData
    {
        public bool Successful { get; set; }

        public List<string> ErrorMessages { get; set; } = new List<string>();
    }
}
