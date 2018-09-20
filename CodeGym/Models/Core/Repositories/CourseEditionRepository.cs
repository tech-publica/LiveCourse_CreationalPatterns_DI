using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGym.Models.Core.Repositories
{
    public interface CourseEditionRepository
    {
        CourseEdition FindById(long id);
        void Remove(long editionId);
        void Add(CourseEdition edition);
        IEnumerable<CourseEdition> FindByCourseId(long id);
        IEnumerable<CourseEdition> FindAll();

    }
}
