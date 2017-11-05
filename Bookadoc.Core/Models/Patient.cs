using System.Collections.Generic;

namespace Bookadoc.Core.Models
{
    public class Patient : User
    {
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public virtual ICollection<PatientDiseaseHistory> PatientsDiseases { get; set; }
    }
}
