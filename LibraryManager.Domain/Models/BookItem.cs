using LibraryManager.Domain.Enums;

namespace LibraryManager.Domain.Models
{
    public class BookItem
    {
        public int BookItemId { get; set; }
        public string? Barcode { get; set; }
        public bool IsReferenceOnly { get; set; }
        public bool IsVirtual { get; set; }
        public Languague Languague { get; set; }
        public double PricePerDay { get; set; }
        public virtual Book? Book { get; set; }
        public virtual Library? Library { get; set; }
        public virtual BookLending? BookLending { get; set; }
        public virtual ICollection<BookReservation>? BookReservation { get; set; }
    }
}
