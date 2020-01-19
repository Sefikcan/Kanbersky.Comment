namespace Kanbersky.Comment.Core.Utilities.Result
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(string message, T data) : base(true, message, data)
        {
        }

        public SuccessDataResult(T data) : base(true, data)
        {
        }

        public SuccessDataResult(string message) : base(true, message, default)
        {
        }

        public SuccessDataResult() : base(true, default)
        {
        }
    }
}
