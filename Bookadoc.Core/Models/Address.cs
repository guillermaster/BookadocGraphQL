using System;
using System.Collections.Generic;
using System.Text;

namespace Bookadoc.Core.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string MainLine { get; set; }
        public string SecondaryLine { get; set; }
        public int  PostCode { get; set; }
        public int IdCity { get; set; }
        public City City { get; set; }
    }
}
