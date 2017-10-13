namespace Bookadoc.Core.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public PhoneTypes Type { get; set; }
    }

    public enum PhoneTypes
    {
        Mobile,
        Home,
        Office
    }
}
