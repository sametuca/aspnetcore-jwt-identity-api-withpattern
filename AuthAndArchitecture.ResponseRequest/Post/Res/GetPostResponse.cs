using System.Collections.Generic;

namespace AuthAndArchitecture.ResponseRequest.Post.Res
{
    public class GetPostResponse
    {
        public GetPostResponse()
        {
            Posts = new List<Domain.Entities.Post>();    
        }
        public List<Domain.Entities.Post> Posts { get; set; }
        public Domain.Entities.Post Post { get; set; }
    }
}
