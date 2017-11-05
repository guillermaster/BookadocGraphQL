namespace Bookadoc.Core.Models
{
    public class PatientDiseaseHistory
    {
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public int DiseaseId { get; set; }
        public Disease Disease { get; set; }
    }
}
