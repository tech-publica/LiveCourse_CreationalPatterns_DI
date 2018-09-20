using CodeGym.Models.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGym.Models.EF
{

    public static class DbInitializer
    {
        private static Dictionary<string, Course> courses;
        private const string TITLE_1 = "C# for Managers";
        private const string TITLE_2 = "Machine Learning";

        public static Dictionary<string, Course> Courses
        {
            get
            {
                if (courses == null)
                {
                    var courseList = new Course[]
                    {
                        new Course
                        {
                            Title =TITLE_1,
                            Description = "You don't have to be dumb to be a manager, really",
                            Level = CourseLevel.Introductory
                        },
                        new Course
                        {
                            Title =TITLE_2,
                            Description = "AIs are going to rule the world, so try to be an early friend",
                            Level = CourseLevel.Advanced
                        }

                    };

                    courses = new Dictionary<string, Course>();

                    foreach (var course in courseList)
                    {
                        courses.Add(course.Title, course);
                    }
                }

                return courses;
            }
        }


        public static void Seed(CodeGymContext context)
        {
            if (!context.Courses.Any())
            {
                context.Courses.AddRange(Courses.Select(c => c.Value));
            }


            if (!context.CourseEditions.Any())
            {
                context.CourseEditions.AddRange
                (
                    new CourseEdition { Course = Courses[TITLE_1], StartDate = DateTime.Today, EndDate = DateTime.Today.AddDays(5), Cost = 1000 },
                    new CourseEdition { Course = Courses[TITLE_1], StartDate = DateTime.Today, EndDate = DateTime.Today.AddDays(5), Cost = 1000 },
                    new CourseEdition { Course = Courses[TITLE_2], StartDate = DateTime.Today, EndDate = DateTime.Today.AddDays(5), Cost = 1000 },
                    new CourseEdition { Course = Courses[TITLE_2], StartDate = DateTime.Today, EndDate = DateTime.Today.AddDays(5), Cost = 1000 }

                );
            }
            context.SaveChanges();
        }
    }
}
