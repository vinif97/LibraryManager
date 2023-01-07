using LibraryManager.Application.Interfaces.ErrorHandler;

namespace LibraryManager.Application.ErrorHandler
{
    public class DatabaseOperationResult : IResult
    {
        public bool IsSuccess { get; set; }
        public IList<string> Errors { get; set; }

        public DatabaseOperationResult()
        {
            Errors = new List<string>();
        }
    }
}
