using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair2_Hw2.Business.Abstracts
{
    public interface IInstructorService
    {
        void Add(CreateInstructorRequest instructor);
        void Delete(DeleteInstructorRequest instructor);
        void Update(UpdateInstructorRequest instructor);
        List<GetAllInstructorResponse> GetAll();
        GetByIdInstructorResponse GetById(int id);
    }
}
