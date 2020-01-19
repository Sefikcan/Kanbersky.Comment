using AutoMapper;
using Kanbersky.Comment.Business.DTO.Request;
using Kanbersky.Comment.Business.DTO.Response;
using Kanbersky.Comment.Entities.Concrete;

namespace Kanbersky.Comment.Business.Mappings.AutoMapper
{
    public class BusinessProfile : Profile
    {
        public BusinessProfile()
        {
            CreateMap<ProductComment, AddCommentRequest>().ReverseMap();
            CreateMap<ProductComment, CommentResponse>().ReverseMap();
        }
    }
}
