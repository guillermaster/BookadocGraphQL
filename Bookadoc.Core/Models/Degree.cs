using System.Collections.Generic;

namespace Bookadoc.Core.Models
{
    public class Degree
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<DoctorDegree> DoctorsDegrees { get; set; }
    }
}
