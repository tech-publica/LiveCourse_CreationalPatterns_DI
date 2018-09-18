using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGym.Models.Core
{
    public class Enrollment
    {
        public long StudentID { get; set; }
        public long CourseEditionId { get; set; }
        public Student Student { get; set; }
        public CourseEdition CourseEdition { get; set; }
        public int Score { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}
