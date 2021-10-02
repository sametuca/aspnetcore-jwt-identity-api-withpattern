using MediatR;
using System.Threading.Tasks;
using TestApp.Command;

namespace TestApp.Facade
{
    public class FacadeClass : IFacade
    {
        private readonly IMediator mediatr;

        public FacadeClass(IMediator _mediatr)
        {
            mediatr = _mediatr;
        }
        Task<StudentResponse> IFacade.GetStudent(StudentRequest request)
        {
            var res = mediatr.Send(request);
            return res;
        }
    }
}
