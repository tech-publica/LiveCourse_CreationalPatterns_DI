using CodeGym.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGym.ViewModels
{
    public class CourseEditionViewModel
    {
        public long Id { get; set; }
        public long CourseId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Cost { get; set; }
      
    }

}
