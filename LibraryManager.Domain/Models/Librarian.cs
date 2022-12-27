namespace LibraryManager.Domain.Models
{
    public class Librarian
    {
        public int LibrarianId { get; set; }
        public int UserId { get; set; }
        public virtual User? User { get; set; }
    }
}
