using CodeGym.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGym.ViewModels.Extensions
{
    public static class ViewModelExtensions
    {
        public static CourseEditionViewModel ToViewModel(this CourseEdition edition)
        {
            return new CourseEditionViewModel()
            {
                Id = edition.Id,
                CourseId = edition.CourseId,
                StartDate = edition.StartDate,
                EndDate = edition.EndDate,
                Cost = edition.Cost
            };
        }
    }
}
