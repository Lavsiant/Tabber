using Model.GuitarTab;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DbRepository.Interfaces
{
    public interface ICourseRepository
    {
        Task<List<Course>> GetAllCourses();

        Task<Course> GetCourse(int id);
    }
}
