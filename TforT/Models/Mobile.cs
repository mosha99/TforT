using System.Collections.Generic;

namespace TforT.Models
{
    public class Mobile
    {    
        public int MobileId { get; set; }
        public int Amount { get; set; }
        public string Number { get; set; }
        public int UserId { get; set; }
        public User user { get; set; }
        public ICollection<UserContacts> Contacts { get; set; }
    }
}
