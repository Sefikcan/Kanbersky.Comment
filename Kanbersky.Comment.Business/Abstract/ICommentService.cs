using Kanbersky.Comment.Business.DTO.Request;
using Kanbersky.Comment.Business.DTO.Response;
using Kanbersky.Comment.Core.Utilities.Result;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kanbersky.Comment.Business.Abstract
{
    public interface ICommentService
    {
        Task<IResult> AddAsync(AddCommentRequest request);

        Task<IDataResult<CommentResponse>> GetByIdAsync(string id);

        Task<IDataResult<List<CommentResponse>>> GetAllAsync();
    }
}
