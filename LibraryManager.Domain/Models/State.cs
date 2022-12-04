using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Domain.Models
{
    public class State
    {
        public int StateId { get; set; }
        public string? StateName { get; set; }
        public virtual Country? Country { get; set; }
        public virtual ICollection<City>? Cities { get; set; }
    }
}
