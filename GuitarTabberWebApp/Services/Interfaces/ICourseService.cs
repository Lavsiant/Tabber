using Model.GuitarTab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuitarTabberWebApp.Services.Interfaces
{
    public interface ICourseService
    {
        Task<List<Course>> GetAllCourses();

        Task<Course> GetCourse(int id);
    }
}
