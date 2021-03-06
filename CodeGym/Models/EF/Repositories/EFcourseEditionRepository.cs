﻿using CodeGym.Models.Core;
using CodeGym.Models.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGym.Models.EF.Repositories
{
    public class EFCourseEditionRepository : CourseEditionRepository
    {
        private CodeGymContext ctx;
        public EFCourseEditionRepository(CodeGymContext ctx)
        {
            this.ctx = ctx;
        }

        public void Add(CourseEdition edition)
        {
            ctx.CourseEditions.Add(edition);
        }

        public CourseEdition FindById(long id)
        {
            return ctx.CourseEditions.Find(id);
        }

        public IEnumerable<CourseEdition> FindAll()
        {
            return ctx.CourseEditions.ToList();
        }

        public IEnumerable<CourseEdition> FindByCourseId(long id)
        {
            return ctx.CourseEditions.Where(ce => ce.CourseId == id).ToList();
        }

        public void Remove(long editionId)
        {
            var toRemove = new CourseEdition { Id = editionId };
            ctx.CourseEditions.Remove(toRemove);
        }
    }
}
