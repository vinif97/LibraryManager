using LibraryManager.Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace LibraryManager.Domain.Models
{
    public class User : IdentityUser<int>
    {
        public Address? Address { get; set; }
        public AccountStatus AccountStatus { get; set; }
        public virtual Member? Member { get; set; }
        public virtual Librarian? Librarian { get; set; }
    }
}
