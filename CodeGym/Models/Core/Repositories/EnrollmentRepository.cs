using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGym.Models.Core.Repositories
{
    public interface EnrollmentRepository
    {
        void EnrollInCourseEdition(CourseEdition edition, Student student);
        void RemoveFromCourseEdition(CourseEdition edition, Student student);
        
    }
}
