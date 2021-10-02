using DeleteProjectResReq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteProjectFacade
{
    public interface IFacade
    {
        Task<StudentResponse> GetStudent(StudentRequest request); 
    }
}
