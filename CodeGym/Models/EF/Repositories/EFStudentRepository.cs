using CodeGym.Models.Core;
using CodeGym.Models.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


namespace CodeGym.Models.EF.Repositories
{
    public class EFStudentRepository : StudentRepository
    {
        private CodeGymContext ctx;
        public EFStudentRepository(CodeGymContext ctx)
        {
            this.ctx = ctx;
        }
        public IEnumerable<Student> BestStudents(int n)
        {
            return ctx.Enrollments
                   .GroupBy(e => e.Student)
                   .OrderByDescending(g => g.Average(e => e.Score))
                   .Take(n)
                   .Select(g => g.Key)
                   .ToList();
        }

        public IEnumerable<Student> BestStudentsForCourseEdition(int n, long courseEditionId)
        {
            return ctx.Enrollments.Include(e => e.Student)
                .Where(e => e.CourseEditionId == courseEditionId)
                .OrderByDescending(e => e.Score)
                .Take(n)
                .Select(e => e.Student)
                .ToList();
        }

        public IEnumerable<Student> BestStudentsForCourse(int n, long courseId)
        {
            return ctx.Enrollments.Include(e => e.Student)
                .Where(e => e.CourseEdition.CourseId == courseId)
                .GroupBy(e => e.Student)
                .OrderByDescending(g => g.Average(e => e.Score))
                .Take(n)
                .Select(g => g.Key)
                .ToList();
        }
    }
}
