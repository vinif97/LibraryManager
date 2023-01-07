using Microsoft.EntityFrameworkCore.Metadata;

namespace LibraryManager.Domain.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        public int TotalCheckoutBooks { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public virtual ICollection<BookLending>? CheckedOutBooks { get; set; }
    }
}
