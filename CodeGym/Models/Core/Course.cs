using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGym.Models.Core
{
    public enum CourseLevel { Introductory, Intermediate, Advanced, DontEvenTry}

    public class Course
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Syllabus { get; set; }
        public string Description { get; set; }
        public string Prerequisites { get; set; }
        public int DurationInHours { get; set; }
        public CourseLevel Level { get; set; }
        public List<CourseEdition> Editions { get; set; } = new List<CourseEdition>();

    }
}
