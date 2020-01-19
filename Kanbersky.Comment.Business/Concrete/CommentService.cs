using AutoMapper;
using Kanbersky.Comment.Business.Abstract;
using Kanbersky.Comment.Business.DTO.Request;
using Kanbersky.Comment.Business.DTO.Response;
using Kanbersky.Comment.Core.Constants;
using Kanbersky.Comment.Core.Utilities.Result;
using Kanbersky.Comment.DAL.Concrete.MongoDB.GenericRepository;
using Kanbersky.Comment.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kanbersky.Comment.Business.Concrete
{
    public class CommentService : ICommentService
    {
        #region fields

        private readonly IGenericRepository<ProductComment> _repository;
        private readonly IMapper _mapper;

        #endregion

        #region ctor

        public CommentService(IGenericRepository<ProductComment> repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        #endregion

        #region methods

        public async Task<IResult> AddAsync(AddCommentRequest request)
        {
            try
            {
                var entity = _mapper.Map<ProductComment>(request);
                await _repository.InsertAsync(entity);
                return new SuccessResult(ResponseMessages.InsertSuccess);
            }
            catch
            {
                return new ErrorResult(ResponseMessages.Error);
            }
        }

        public async Task<IDataResult<List<CommentResponse>>> GetAllAsync()
        {
            var response = await _repository.FindAllAsync();
            if (!response.Any())
            {
                return new ErrorDataResult<List<CommentResponse>>(ResponseMessages.NotFound);
            }
            return new SuccessDataResult<List<CommentResponse>>(_mapper.Map<List<CommentResponse>>(response));
        }

        public async Task<IDataResult<CommentResponse>> GetByIdAsync(string id)
        {
            var response = await _repository.GetByIdAsync(id);
            if (response == null)
            {
                return new ErrorDataResult<CommentResponse>(ResponseMessages.NotFound);
            }
            return new SuccessDataResult<CommentResponse>(_mapper.Map<CommentResponse>(response));
        }

        #endregion
    }
}
