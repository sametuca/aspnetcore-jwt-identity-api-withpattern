using System.Threading.Tasks;
using TestApp.Command;

namespace TestApp.Facade
{
    public interface IFacade
    {
        Task<StudentResponse> GetStudent(StudentRequest request);
    }
}
