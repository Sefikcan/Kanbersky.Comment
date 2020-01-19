namespace Kanbersky.Comment.Business.DTO.Request
{
    public class AddCommentRequest
    {
        public int ProductId { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public int Rating { get; set; }
    }
}
