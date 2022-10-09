using LibraryManager.Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace LibraryManager.Domain.Models
{
    public class User : IdentityUser
    {
        public Address Address { get; set; }
    }
}
