using DeleteProjectFacade;
using DeleteProjectResReq;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DeleteProjectHandlers.Handlers
{
    public class GetStudentHandler : IRequestHandler<StudentRequest, StudentResponse>
    {
        public Task<StudentResponse> Handle(StudentRequest request, CancellationToken cancellationToken)
        {
            var response = new StudentResponse { Name = "samet" };
            return Task.FromResult(response);
        }
    }

}
