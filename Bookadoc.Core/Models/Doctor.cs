using System.Collections.Generic;

namespace Bookadoc.Core.Models
{
    public class Doctor : User
    {
        public virtual ICollection<DoctorSpeciality> DoctorSpecialities { get; set; }
        public virtual ICollection<DoctorDegree> DoctorDegrees { get; set; }
    }
}
