namespace Bookadoc.Core.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Idstate { get; set; }
        public State State { get; set; }
    }
}
