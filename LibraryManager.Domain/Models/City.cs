using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Domain.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string? CityName { get; set; }
        public virtual State? State { get; set; }
        public virtual ICollection<Address>? Addresses { get; set; }
    }
}
