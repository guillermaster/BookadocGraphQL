namespace Bookadoc.Core.Models
{
    public class DoctorDegree
    {
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public int DegreeId { get; set; }
        public Degree Degree { get; set; }
    }
}
