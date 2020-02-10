using Kanbersky.Comment.Business.Abstract;
using Kanbersky.Comment.Business.DTO.Request;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Kanbersky.Comment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        #region fields

        private readonly ICommentService _commentService;
        private readonly ILogger<CommentsController> _logger;

        #endregion

        #region ctor

        public CommentsController(ICommentService commentService,
            ILogger<CommentsController> logger)
        {
            _commentService = commentService;
            _logger = logger;
        }

        #endregion

        #region methods

        [HttpGet]
        [Route("all-comments")]
        public async Task<IActionResult> GetAllAsync()
        {
            var response = await _commentService.GetAllAsync();
            if (response.Success)
            {
                return Ok(response.Data);
            }
            return BadRequest(response.Message);
        }

        [HttpGet]
        [Route("comment/{id}")]
        public async Task<IActionResult> GetByIdAsync(string id)
        {
            var response = await _commentService.GetByIdAsync(id);
            if (response.Success)
            {
                return Ok(response.Data);
            }
            else
            {
                return BadRequest(response.Message);
            }
        }

        [HttpPost]
        [Route("add-comment")]
        public async Task<IActionResult> AddAsync([FromBody]AddCommentRequest addCommentRequest)
        {
            var response = await _commentService.AddAsync(addCommentRequest);
            if (response.Success)
            {
                return Ok();
            }
            else
            {
                return BadRequest(response.Message);
            }
        }

        [HttpGet]
        [Route("Throw-Error")]
        public IActionResult ThrowError()
        {
            throw new System.Exception("Hata!");
        }

        #endregion
    }
}