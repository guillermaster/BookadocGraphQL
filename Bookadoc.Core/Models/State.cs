namespace Bookadoc.Core.Models
{
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdCountry { get; set; }
        public Country Country { get; set; }
    }
}
