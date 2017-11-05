using System.Collections.Generic;

namespace Bookadoc.Core.Models
{
    public class Disease
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<PatientDiseaseHistory> PatientsDiseases { get; set; }
    }
}
