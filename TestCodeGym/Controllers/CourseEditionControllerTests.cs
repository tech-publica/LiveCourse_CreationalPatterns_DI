﻿using CodeGym.Controllers;
using CodeGym.Models.Core.Repositories;
using CodeGym.Models.Core.UnitOfWorks;
using CodeGym.ViewModels;
using Moq;
using System;
using Xunit;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using CodeGym.Models.Core;

namespace TestCodeGym.Controllers
{
    public class CourseEditionControllerTests
    {
        private const int VALID_COURSE_ID = 1;
        private readonly DateTime START_DATE = DateTime.Today;
        private readonly DateTime VALID_END_DATE = DateTime.Today.AddDays(1);
        private readonly DateTime INVALID_END_DATE = DateTime.Today.AddDays(-1);
        private const decimal COST = 1234;
        private CourseEditionController controller;
        private Mock<CourseRepository> mockCourseRepository;
        private Mock<CourseEditionRepository> mockCourseEditionRepository;
        private Mock<CourseEditionUnitOfWork> mockCourseEditionUnitOfWork;

        public CourseEditionControllerTests()
        {
            mockCourseRepository = new Mock<CourseRepository>();
            mockCourseEditionRepository = new Mock<CourseEditionRepository>();
            mockCourseEditionUnitOfWork = new Mock<CourseEditionUnitOfWork>();
            mockCourseEditionUnitOfWork.SetupGet(u => u.Courses).Returns(mockCourseRepository.Object);
            mockCourseEditionUnitOfWork.SetupGet(u => u.CourseEditions).Returns(mockCourseEditionRepository.Object);
            controller = new CourseEditionController(mockCourseEditionUnitOfWork.Object);

        }

        [Fact]
        public void CreateCourseEdition()
        {
            var courseEditionViewModel = new CourseEditionViewModel { StartDate = DateTime.Today,  EndDate = VALID_END_DATE,  CourseId = VALID_COURSE_ID, Cost = COST};
            mockCourseRepository.Setup(r => r.FindByID(VALID_COURSE_ID)).Returns(new Course { Id = VALID_COURSE_ID });
            var result = controller.CreateCourseEdition(courseEditionViewModel);
            result.Should().BeOfType<CreatedAtRouteResult>();
            CreatedAtRouteResult created = result as CreatedAtRouteResult;
            created.RouteName.Should().BeEquivalentTo(CourseEditionController.GET_COURSE_EDITION_ROUTE_NAME);
            created.Value.Should().Be(courseEditionViewModel);
        }


        [Fact]
        public void CreateCourseEdition_WithInvalidCourseId_ShouldResultInBadRequest()
        {
            
        }
    }
}
