using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair2_Hw2.Business.Abstracts
{
    public interface ICourseService
    {
        void Add(CreateCourseRequest course);
        void Delete(DeleteCourseRequest course);
        void Update(UpdateCourseRequest course);
        List<GetAllCourseResponse> GetAll();
        GetByIdCourseResponse GetById(int id);
    }
}
