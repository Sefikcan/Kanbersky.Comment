namespace Kanbersky.Comment.Core.Utilities.Result
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        protected DataResult(bool success, string message, T data) : base(success, message)
        {
            Data = data;
        }

        protected DataResult(bool success, T data) : base(success)
        {
            Data = data;
        }

        public T Data { get; }
    }
}
