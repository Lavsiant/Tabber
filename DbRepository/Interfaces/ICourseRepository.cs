using Model.GuitarTab;
using Model.UserModel;
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

        List<User> GetAllSubscribedUsers(int courseId);

        Task CreateCourse(CourseCreateViewModel course);

        Task DeleteCourse(int id);

        Task AddCourseToUser(int id, string username);
    }
}
