﻿using System.Collections.Generic;

namespace Bookadoc.Core.Models
{
    public class Speciality
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<DoctorSpeciality> DoctorSpecialities { get; set; }
    }
}
