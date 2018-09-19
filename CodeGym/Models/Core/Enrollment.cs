using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGym.Models.Core
{
    public class Enrollment
    {
        public Enrollment() { }
        public Enrollment(long courseEditionId, long studentId)
        {
            CourseEditionId = courseEditionId;
            StudentId = studentId;
        }
        public long StudentId { get; set; }
        public long CourseEditionId { get; set; }
        public Student Student { get; set; }
        public CourseEdition CourseEdition { get; set; }
        public int Score { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}
