using LibraryManager.Domain.Enums;

namespace LibraryManager.Domain.Models
{
    public class BookItem
    {
        public int BookItemId { get; set; }
        public string Barcode { get; set; }
        public bool IsReferenceOnly { get; set; }
        public bool IsVirtual { get; set; }
        public Languague Languague { get; set; }
        public double PricePerDay { get; set; }
        public int MemberId { get; set; }
        public Member? Member { get; set; }
        public BookReservation? BookReservation { get; set; }
        public BookLending? BookLending { get; set; }
        
    }
}
