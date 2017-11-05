using System.Collections.Generic;

namespace Bookadoc.Core.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
        public int UserTypeId { get; set; }
        public IEnumerable<Address> Addresses { get; set; }
        public IEnumerable<Phone> PhoneNumbers { get; set; }
    }
}
