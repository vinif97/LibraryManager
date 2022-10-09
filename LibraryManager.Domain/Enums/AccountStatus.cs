using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Domain.Enums
{
    public enum AccountStatus
    {
        None = 0,
        Active = 1,
        Closed = 2,
        Blacklisted = 3
    }
}
