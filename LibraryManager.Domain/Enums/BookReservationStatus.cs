using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Domain.Enums
{
    public enum BookReservationStatus
    {
        None = 0,
        Pending = 1,
        Completed = 2,
        Canceled = 3,
    }
}
