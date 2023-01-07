namespace LibraryManager.Domain.Models
{
    public class Library
    {
        public int LibraryId { get; set; }
        public string? Name { get; set; }
        public virtual Address? Address { get; set; }
        public ICollection<BookItem>? BookItems { get; set; }
    }
}
