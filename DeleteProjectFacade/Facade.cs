using DeleteProjectResReq;
using MediatR;
using System.Threading.Tasks;

namespace DeleteProjectFacade
{
    public class Facade : IFacade
    {
        readonly IMediator mediator;
        public Facade(IMediator med)
        {
            mediator = med;
        }
        public Task<StudentResponse> GetStudent(StudentRequest request)
        {
            var response  = mediator.Send(request);
            return response;
        }
    }
}
