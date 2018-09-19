using CodeGym.Models.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGym.Models.Core.UnitOfWorks
{
    public interface CourseEditionUnitOfWork
    {
        CourseEditionRepository CourseEditions { get;}
        CourseRepository Courses{ get;}
        void Begin();
        void End();
        void Cancel(Course c);
    }
}
