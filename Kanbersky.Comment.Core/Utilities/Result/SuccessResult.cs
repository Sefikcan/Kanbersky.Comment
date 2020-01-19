namespace Kanbersky.Comment.Core.Utilities.Result
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true, message)
        {
        }

        public SuccessResult(bool success) : base(success)
        {
        }

        public SuccessResult() : base(true)
        {
        }
    }
}
