using System;
using System.Collections.Generic;
using System.Text;

namespace Bookadoc.Core.Models
{
    public class Patient : User
    {
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public virtual ICollection<Disease> KnownDiseases { get; set; }
    }
}
