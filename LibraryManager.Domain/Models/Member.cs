namespace LibraryManager.Domain.Models
{
    public class Member : User
    {
        public int TotalCheckoutBooks { get; set; }
        public ICollection<BookItem> CheckedoutBooks { get; set; }
    }
}
