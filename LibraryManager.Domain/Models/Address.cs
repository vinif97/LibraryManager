namespace LibraryManager.Domain.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string? StreetAddress { get; set; }
        public short Number { get; set; }
        public string? Complement { get; set; }
        public string? Reference { get; set; }
        public virtual City? City { get; set; }
        public string? Zipcode { get; set; }
        public int UserId { get; set; }
        public virtual User? User { get; set; }
        public int LibraryId { get; set; }
        public virtual Library? Library { get; set; }
    }
}
