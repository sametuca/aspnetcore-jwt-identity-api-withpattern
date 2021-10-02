using AuthAndArchitecture.ResponseRequest.Post.Req;
using AuthAndArchitecture.ResponseRequest.Post.Res;
using System.Threading.Tasks;

namespace AuthAndArchitecture.Facade.Abstract
{
    public interface IPostFacade
    {
        public Task<GetPostResponse> GetAllPost(GetPostRequest request);
    }
}
