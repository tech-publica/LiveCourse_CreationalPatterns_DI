using CodeGym.Models.Core;
using CodeGym.Models.Core.Repositories;
using CodeGym.Models.EF;
using CodeGym.Models.EF.Repositories;
using Microsoft.EntityFrameworkCore;
using Moq;
using Xunit;
using FluentAssertions;
using System.Linq;
using System;

namespace TestCodeGym.Repositories
{
    public class EFStudentRepositoryTests
    {
        private StudentRepository studentRepository;
        private CodeGymContext ctx;
        private const string TEST_NAME= "TEST_NAME";
        private const string TEST_TITLE = "TEST_TITLE";
        private Course[] courses;
        private CourseEdition[] courseEditions;
        private static int counter = 0;

        public EFStudentRepositoryTests()
        {

            var options = new DbContextOptionsBuilder<CodeGymContext>()
                    .UseInMemoryDatabase("InMemory" + counter++)
                    .Options;
            ctx = new CodeGymContext(options);          
            studentRepository = new EFStudentRepository(ctx);
            courses = new Course[2];
            courseEditions = new CourseEdition[3];
            CreateEnrollmentsForBestStudentsTest();

        }

       


        [Fact]
        public void Best_Students_For_Course_Edition()
        {

           // CreateEnrollmentsForBestStudentsTest();
            var bestStudents = studentRepository.BestStudentsForCourseEdition(2, courseEditions[0].Id).ToList();
            bestStudents.Should().HaveCount(2);
            bestStudents[0].Name.Should().Be(TEST_NAME + 1);
            bestStudents[1].Name.Should().Be(TEST_NAME + 2);

            bestStudents = studentRepository.BestStudentsForCourseEdition(2, courseEditions[2].Id).ToList();
            bestStudents.Should().HaveCount(2);
            bestStudents[0].Name.Should().Be(TEST_NAME + 0);
            bestStudents[1].Name.Should().Be(TEST_NAME + 2);

        }


        [Fact]
        public void Best_Students_For_Course()
        {

            var bestStudents = studentRepository.BestStudentsForCourse(2, courses[0].Id).ToList();
            bestStudents.Should().HaveCount(2);
            bestStudents[0].Name.Should().Be(TEST_NAME + 1);
            bestStudents[1].Name.Should().Be(TEST_NAME + 3);

            bestStudents = studentRepository.BestStudentsForCourse(2, courses[1].Id).ToList();
            bestStudents.Should().HaveCount(2);
            bestStudents[0].Name.Should().Be(TEST_NAME + 0);
            bestStudents[1].Name.Should().Be(TEST_NAME + 2);

        }


        [Fact]
        public void Best_Students()
        {

            // CreateEnrollmentsForBestStudentsTest();
            var bestStudents = studentRepository.BestStudents(2).ToList();
            bestStudents.Should().HaveCount(2);
            bestStudents[0].Name.Should().Be(TEST_NAME + 1);
            bestStudents[1].Name.Should().Be(TEST_NAME + 0);

        }

        private void CreateEnrollmentsForBestStudentsTest()
        {

            // best 2  students for course 0: student 1 with a 410, student 3 with an average of (230 + 200)/2
            // best 2  students for edition 0: student 1 with 410 , student 2 with 210  
            // best 2  students for course 1 : student 0 with 500 , second student 2 with 420
            // best 2  students overall : student  2 with 415 , student 1 with 410

            var students = new Student[4];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student { Name = TEST_NAME + i, BirthDate = DateTime.Today.AddYears(-20) };
            }
            for(int i=0; i < courses.Length;i++)
            {
                courses[i] = new Course { Title = TEST_TITLE + i ,DurationInHours = 40, Level = CourseLevel.Introductory};
            }
            for(int i = 0; i < courseEditions.Length; i++)
            {  
                courseEditions[i] = new CourseEdition { Course = i < (courseEditions.Length - 1) ? courses[0] : courses[1], StartDate = DateTime.Today, EndDate = DateTime.Today.AddDays(1), Cost = 1000};
            }
            var enrollments = new Enrollment[8];

            enrollments[0] =  new Enrollment { Score = 200, Student = students[0], CourseEdition = courseEditions[0], EnrollmentDate = DateTime.Today };
            enrollments[1] =  new Enrollment { Score = 410, Student = students[1], CourseEdition = courseEditions[0], EnrollmentDate = DateTime.Today };
            enrollments[2] =  new Enrollment { Score = 210, Student = students[2], CourseEdition = courseEditions[0], EnrollmentDate = DateTime.Today };
            enrollments[3] =  new Enrollment { Score = 200, Student = students[3], CourseEdition = courseEditions[0], EnrollmentDate = DateTime.Today };
            enrollments[4] =  new Enrollment { Score = 230, Student = students[3], CourseEdition = courseEditions[1], EnrollmentDate = DateTime.Today };
            enrollments[5] =  new Enrollment { Score = 500, Student = students[0], CourseEdition = courseEditions[2], EnrollmentDate = DateTime.Today };
            enrollments[6] =  new Enrollment { Score = 420, Student = students[2], CourseEdition = courseEditions[2], EnrollmentDate = DateTime.Today };
            enrollments[7] =  new Enrollment { Score =  50, Student = students[3], CourseEdition = courseEditions[2], EnrollmentDate = DateTime.Today };
       
            ctx.Enrollments.AddRange(enrollments);
            ctx.SaveChanges();
        }

    }
}
