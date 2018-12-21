using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuitarTabberWebApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Model.GuitarTab;

namespace GuitarTabberWebApp.Controllers
{
    [Route("api/[controller]")]
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        [Route("all-courses")]
        public async Task<List<Course>> GetAllCourses()
        {
            return await _courseService.GetAllCourses();
           // return Ok(result);
        }

        [HttpGet]
        [Route("course")]
        public async Task<IActionResult> GetCourse(int id)
        {
            var result = await _courseService.GetCourse(id);
            return Ok(result);
        }

        [HttpGet]
        [Route("subs")]
        public IActionResult GetAllSubscribedUsers(int id)
        {
            var result = _courseService.GetAllSubscribedUsers(id);
            return Ok(result);
        }

    }
}