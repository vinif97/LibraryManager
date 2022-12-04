using LibraryManager.Domain.Enums;

namespace LibraryManager.Domain.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string? Title { get; set; }
        public virtual Publisher? Publisher { get; set; }
        public short PublishedYear { get; set; }
        public Category Category { get; set; }
        public virtual ICollection<Author>? Authors { get; set; }
        public virtual ICollection<BookItem>? BookItems { get; set; }
    }
}
