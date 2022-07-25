namespace TforT.Models
{
    public class UserContacts
    {
        public int UserContactsId { get; set; }
        public int UserId { get; set; }
        public User user { get; set; }
        public int MobileId { get; set; }
        public Mobile mobile { get; set; }
    }
}
