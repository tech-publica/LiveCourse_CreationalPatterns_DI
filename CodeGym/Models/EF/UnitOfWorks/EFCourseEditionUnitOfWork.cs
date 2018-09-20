using CodeGym.Models.Core;
using CodeGym.Models.Core.Repositories;
using CodeGym.Models.Core.UnitOfWorks;



namespace CodeGym.Models.EF.UnitOfWorks
{
    public class EFCourseEditionUnitOfWork : CourseEditionUnitOfWork
    {
        public EFCourseEditionUnitOfWork(CourseRepository courses, CourseEditionRepository courseEditions, CodeGymContext ctx)
        {
            this.Courses = courses;
            this.CourseEditions = courseEditions;
            this.ctx = ctx;
        }

        private CodeGymContext ctx;
        public CourseEditionRepository CourseEditions { get;}
        public CourseRepository Courses { get;}

        public void Begin()
        {
           ctx.Database.BeginTransaction();
        }

        public void Cancel(Course c)
        {
            ctx.Database.CurrentTransaction?.Rollback();
        }

        public void Save()
        {
            ctx.SaveChanges();
        }

        public void End()
        {
            ctx.Database.CurrentTransaction?.Commit();
        }
    }
}
