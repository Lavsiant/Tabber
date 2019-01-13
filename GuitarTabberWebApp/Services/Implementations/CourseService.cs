using DbRepository.Interfaces;
using GuitarTabberWebApp.Services.Interfaces;
using GuitarTabberWebApp.ViewModels;
using Model.GuitarTab;
using Model.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuitarTabberWebApp.Services.Implementations
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task<List<Course>> GetAllCourses()
        {
            return await _courseRepository.GetAllCourses();
        }

        public async Task<Course> GetCourse(int id)
        {
            return await _courseRepository.GetCourse(id);
        }

        public List<User> GetAllSubscribedUsers(int id)
        {
            return  _courseRepository.GetAllSubscribedUsers(id);
        }

        public async Task CreateCourse(CourseCreateViewModel vm)
        {

            await _courseRepository.CreateCourse(vm);
        }

        public async Task DeleteCourse(int id)
        {
            await _courseRepository.DeleteCourse(id);
        }

        public async Task AddCourseToUser(int id, string username)
        {
            await _courseRepository.AddCourseToUser(id, username);
        }

        public async Task ActivateCourse(int id, int index)
        {
            await _courseRepository.ActivateCourse(id, index);
        }

        public async Task<ActiveCourse> GetActivatedCourse()
        {
            return await _courseRepository.GetActivatedCourse();
        }
    }
}
