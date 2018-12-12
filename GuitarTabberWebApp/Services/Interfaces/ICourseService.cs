using GuitarTabberWebApp.ViewModels;
using Model.GuitarTab;
using Model.UserModel;
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

        List<User> GetAllSubscribedUsers(int courseId);

        Task CreateCourse(CourseCreateViewModel course);

        Task DeleteCourse(int id);
    }
}
