namespace LibraryManager.Domain.Models
{
    public class BookLending
    {
        public int BookLendingId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public virtual Member? Member { get; set; }
        public int BookItemId { get; set; }
        public virtual BookItem? BookItem { get; set; }
    }
}
