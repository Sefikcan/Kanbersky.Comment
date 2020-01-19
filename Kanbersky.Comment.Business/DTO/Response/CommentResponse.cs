using System;

namespace Kanbersky.Comment.Business.DTO.Response
{
    public class CommentResponse
    {
        public string Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime ModifiedOn { get; set; }

        public int ProductId { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public int Rating { get; set; }
    }
}
