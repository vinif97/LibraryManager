namespace LibraryManager.Domain.Models
{
    public class Publisher
    {
        public int PublisherId { get; set; }
        public string? PublisherName { get; set; }
        public virtual ICollection<Book>? Books { get; set; }
    }
}
