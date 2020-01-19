namespace Kanbersky.Comment.Core.Utilities.Result
{
    public class Result : IResult
    {
        protected Result(bool success, string message)
        {
            Message = message;
            Success = success;
        }

        protected Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
