using AuthAndArchitecture.Facade.Abstract;
using AuthAndArchitecture.ResponseRequest.Post.Req;
using AuthAndArchitecture.ResponseRequest.Post.Res;
using MediatR;
using System.Threading.Tasks;

namespace AuthAndArchitecture.Facade.Post
{
    public class PostFacade : IPostFacade
    {
        IMediator mediator;
        public PostFacade(IMediator _mediator)
        {
            mediator = _mediator;
        }

        public Task<GetPostResponse> GetAllPost(GetPostRequest request)
        {
            var response = mediator.Send(request);
            return response;
        }
    }
}
