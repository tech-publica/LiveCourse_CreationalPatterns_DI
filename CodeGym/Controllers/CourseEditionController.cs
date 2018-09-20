using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeGym.Models.Core;
using CodeGym.Models.Core.UnitOfWorks;
using CodeGym.ViewModels;
using CodeGym.ViewModels.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeGym.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/courseEditions")]
    [ApiController]
    public class CourseEditionController : ControllerBase
    {
        private CourseEditionUnitOfWork editionWork;

        public CourseEditionController(CourseEditionUnitOfWork editionWork)
        {
            this.editionWork = editionWork;
        }

        [HttpGet("{id}", Name = "GetCourseEdition")]
        public IActionResult GetCourseEdition(int id)
        {
            if (id < 1)
            {
                return BadRequest();
            }
            var edition = editionWork.CourseEditions.FindById(id);
            return Ok(edition.ToViewModel());
        }

        [HttpGet("{courseId}/editions")]
        public IActionResult GetCourseEditions(int courseId)
        {
            if(courseId < 1)
            {
                return BadRequest();
            }
            var editions = editionWork.CourseEditions.FindByCourseId(courseId).Select(c => c.ToViewModel());
            return Ok(editions);
        }

        [HttpGet]
        public IActionResult GetCourseEditions()
        {
            var editions = editionWork.CourseEditions.FindAll().Select(c => c.ToViewModel()); ;
            return Ok(editions);
        }


        [HttpPost("{courseId}/edition")]
        public IActionResult CreateCourseEdition(int courseId,
            [FromBody] CourseEditionViewModel editionViewModel)
        {
            if(courseId < 0 || editionViewModel == null)
            {
                return BadRequest();
            }
            if(editionViewModel.StartDate >= editionViewModel.EndDate)
            {
                ModelState.AddModelError("StartDate", "Start date must be prior to end date.");

            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            editionWork.Begin();
            var course = editionWork.Courses.FindByID(courseId);
            if(course == null)
            {
                return NotFound();
            }
            var edition = new CourseEdition()
            {
                CourseId = courseId,
                StartDate = editionViewModel.StartDate,
                EndDate = editionViewModel.EndDate,
                Cost = editionViewModel.Cost
            };
            editionWork.CourseEditions.Add(edition);
            editionWork.Save();
            editionWork.End();
            return CreatedAtRoute("GetCourseEdition",
                new {edition.Id }, edition.ToViewModel());

        }
    }
}


