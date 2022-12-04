using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Domain.Models
{
    public class Librarian
    {
        public int LibrarianId { get; set; }
        public int UserId { get; set; }
        public virtual User? User { get; set; }
    }
}
