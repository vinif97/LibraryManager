namespace LibraryManager.Domain.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string StreetAddress { get; set; }
        public short Number { get; set; }
        public string? Complement { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zipcode { get; set; }
    }
}
