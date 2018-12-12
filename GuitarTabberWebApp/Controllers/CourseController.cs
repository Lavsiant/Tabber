using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuitarTabberWebApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GuitarTabberWebApp.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        [Route("all-courses")]
        public async Task<IActionResult> GetAllCourses()
        {
            var result = await _courseService.GetAllCourses();
            return Ok(result);
        }

        [HttpGet]
        [Route("all-courses")]
        public async Task<IActionResult> GetCourse(int id)
        {
            var result = await _courseService.GetCourse(id);
            return Ok(result);
        }

        [HttpGet]
        [Route("all-courses")]
        public IActionResult GetAllSubscribedUsers(int id)
        {
            var result = _courseService.GetAllSubscribedUsers(id);
            return Ok(result);
        }

    }
}