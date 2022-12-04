using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Domain.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string? CountryName { get; set; }
        public virtual ICollection<State>? States { get; set; }
    }
}
