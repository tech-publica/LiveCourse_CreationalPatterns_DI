using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGym.Models.Core.Repositories
{
    public interface CourseRepository
    {
        Course FindByID(long id);
    }
}
