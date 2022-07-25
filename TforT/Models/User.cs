namespace TforT.Models
{
    public class User
    {  
        public int UserId { get; set; }
        public string Name { get; set; }   
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Mobile mobile { get; set; }
    }
}
