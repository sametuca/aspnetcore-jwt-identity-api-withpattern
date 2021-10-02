using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace TestApp.Command
{
    public class GetStudentHandler : IRequestHandler<StudentRequest, StudentResponse>
    {
        public Task<StudentResponse> Handle(StudentRequest request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
