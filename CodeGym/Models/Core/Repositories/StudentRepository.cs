using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGym.Models.Core.Repositories
{
    public interface StudentRepository
    {
        IEnumerable<Student> BestStudents(int n);

        IEnumerable<Student> BestStudentsForCourse(int n, long courseId);

        IEnumerable<Student> BestStudentsForCourseEdition(int n, long courseEditionId);
    }
}
