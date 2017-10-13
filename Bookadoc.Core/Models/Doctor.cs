using System.Collections.Generic;

namespace Bookadoc.Core.Models
{
    public class Doctor : User
    {
        public virtual ICollection<Speciality> Specialities { get; set; }
        public virtual ICollection<Degree> Degrees { get; set; }
    }
}
