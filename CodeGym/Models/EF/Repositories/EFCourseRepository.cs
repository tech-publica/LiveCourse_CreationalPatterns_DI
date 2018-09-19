using CodeGym.Models.Core;
using CodeGym.Models.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGym.Models.EF.Repositories
{
    public class EFCourseRepository : CourseRepository
    {
        private CodeGymContext ctx;
        public EFCourseRepository(CodeGymContext ctx)
        {
            this.ctx = ctx;
        }
        public Course FindByID(long id)
        {
            return ctx.Courses.Find(id);
        }
    }
}
