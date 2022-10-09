namespace LibraryManager.Domain.Models
{
    public class BookReservation
    {
        public int BookReservationId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EndDate { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }

    }
}
