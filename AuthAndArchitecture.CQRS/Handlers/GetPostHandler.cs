using AuthAndArchitecture.Domain.Entities;
using AuthAndArchitecture.ResponseRequest.Post.Req;
using AuthAndArchitecture.ResponseRequest.Post.Res;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AuthAndArchitecture.CQRS.Handlers
{
    public class GetPostHandler : IRequestHandler<GetPostRequest, GetPostResponse>
    {
        public Task<GetPostResponse> Handle(GetPostRequest request, CancellationToken cancellationToken)
        {
            var response = new GetPostResponse
            {
                Posts = new List<Post>
                {
                    new Post
                    {
                        Id = 1,
                        Title = "Test",
                        Description = "Test",
                    },
                    new Post
                    {
                        Id = 2,
                        Title = "Test",
                        Description = "Test",
                    }
                }
            };
            return Task.FromResult(response);
        }
    }
}
