using LibraryManager.Domain.Enums;

namespace LibraryManager.Domain.Models
{
    public class User
    {
        public int UserId { get; set; }
        public Address Address { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
    }
}
