using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeGym.Models.Core;
using CodeGym.Models.Core.UnitOfWorks;
using CodeGym.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeGym.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseEditionController : ControllerBase
    {
        private CourseEditionUnitOfWork editionWork;

        public CourseEditionController(CourseEditionUnitOfWork editionWork)
        {
            this.editionWork = editionWork;
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
                StartDate = editionViewModel.StartDate,
                EndDate = editionViewModel.EndDate,
                Cost = editionViewModel.Cost
            };
            editionWork.CourseEditions.Add(edition);
            editionWork.End();
            return CreatedAtRoute("GetCourseEdition",
                new { CourseId = courseId, edition.Id }, edition);

        }
    }
}


