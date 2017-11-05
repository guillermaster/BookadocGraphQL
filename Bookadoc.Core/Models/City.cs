namespace Bookadoc.Core.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdCountry { get; set; }
        public int IdState { get; set; }
        public State State { get; set; }
        public Country Country { get; set; }
    }
}
