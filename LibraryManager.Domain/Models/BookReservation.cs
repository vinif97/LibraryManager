using LibraryManager.Domain.Enums;

namespace LibraryManager.Domain.Models
{
    public class BookReservation
    {
        public int BookReservationId { get; set; }
        public BookReservationStatus BookReservationStatus { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? EndDate { get; set; }
        public virtual BookItem? BookItem { get; set; }
    }
}
