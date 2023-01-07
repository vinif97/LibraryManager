using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Application.Interfaces.ErrorHandler
{
    public interface IResult
    {
        public bool IsSuccess { get; set; }
        public IList<string> Errors { get; set; }
    }
}
