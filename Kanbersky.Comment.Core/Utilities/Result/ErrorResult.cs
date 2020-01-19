namespace Kanbersky.Comment.Core.Utilities.Result
{
    public class ErrorResult : Result
    {
        public ErrorResult(string message) : base(false, message)
        {
        }

        public ErrorResult(bool success) : base(success)
        {
        }

        public ErrorResult() : base(false)
        {
        }
    }
}
