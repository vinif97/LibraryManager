namespace LibraryManager.Domain.Models
{
    public class BookLending
    {
        public int BookLendingId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
