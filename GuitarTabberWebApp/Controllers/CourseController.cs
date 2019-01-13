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
        public async Task<Course> GetCourse(int id)
        {
            var result = new Course();
            try
            {
                 result = await _courseService.GetCourse(id);
            }
            catch(Exception e)
            {

            }
            return result;
        }

        [HttpGet]
        [Route("subs")]
        public IActionResult GetAllSubscribedUsers(int id)
        {
            var result = _courseService.GetAllSubscribedUsers(id);
            return Ok(result);
        }

        [HttpGet]
        [Route("course-add")]
        public IActionResult AddCourse(int id,string username)
        {
            _courseService.AddCourseToUser(id, username);
            return Ok();
        }

        [HttpPost]
        [Route("course-create")]
        public IActionResult CourseCreate([FromBody] CourseCreateViewModel cvm,string name)
        {
            cvm.UserName = name;
            _courseService.CreateCourse(cvm);
            return Ok();
        }

    }
}