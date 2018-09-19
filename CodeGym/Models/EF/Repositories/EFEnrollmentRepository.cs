using CodeGym.Models.Core;
using CodeGym.Models.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGym.Models.EF.Repositories
{
    public class EFEnrollmentRepository : EnrollmentRepository
    {
        private CodeGymContext ctx;
        public EFEnrollmentRepository(CodeGymContext ctx)
        {
            this.ctx = ctx;
        }
        public void EnrollInCourseEdition(CourseEdition edition, Student student)
        {
            Enrollment enro = new Enrollment(edition.Id, student.Id);
            ctx.Enrollments.Add(enro);
        }

        public void RemoveFromCourseEdition(CourseEdition edition, Student student)
        {
            Enrollment enro = new Enrollment(edition.Id, student.Id);
            ctx.Enrollments.Remove(enro);
        }
    }
}
