﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.Content.Core.DataServices.Models.Attributes
{
    public class RelatedParam : Attribute
    {
        private string _fieldName;
        public RelatedParam(string fkFieldName)
        {
            _fieldName = fkFieldName;
        }
    }
}
