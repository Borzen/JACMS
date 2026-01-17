using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JACMS.API.DataAccess.Core.Models.Identity
{
    public class Role : IdentityRole<long>
    {
        /// <summary>
        /// gets or sets the creation date
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// gets or sets the update date
        /// </summary>
        public DateTime UpdateDate { get; set; }
    }
}
