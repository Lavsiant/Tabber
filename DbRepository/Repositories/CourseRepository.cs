using DbRepository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.GuitarTab;
using Model.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbRepository.Repositories
{
    public class CourseRepository : BaseRepository, ICourseRepository
    {
        public CourseRepository(string connectionString, IRepositoryContextFactory contextFactory) : base(connectionString, contextFactory) { }

        public async Task<List<Course>> GetAllCourses()
        {
            using (var context = ContextFactory.CreateDbContext(ConnectionString))
            {
                return await context.Courses.ToListAsync();
            }
        }

        public async Task<Course> GetCourse(int id)
        {
            using (var context = ContextFactory.CreateDbContext(ConnectionString))
            {
                return await context.Courses.FirstOrDefaultAsync(x=>x.ID == id);
            }
        }

        public List<User> GetAllSubscribedUsers(int courseId)
        {
            var usersList = new List<User>();

            using (var context = ContextFactory.CreateDbContext(ConnectionString))
            {
                foreach (var user in context.Users)
                {
                    var findedUser = user.Courses.FirstOrDefault(x => x.ID == courseId);
                    if (findedUser != null)
                    {
                        usersList.Add(user);
                    }
                }              
            }
            return usersList;
        }

        public async Task CreateCourse(Course course)
        {
            using (var context = ContextFactory.CreateDbContext(ConnectionString))
            {
                context.Courses.Add(course);
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteCourse(int id)
        {
            using (var context = ContextFactory.CreateDbContext(ConnectionString))
            {
                var course = await context.Courses.FirstOrDefaultAsync(x => x.ID == id);
                if (course != null)
                {
                    context.Courses.Remove(course);
                    await context.SaveChangesAsync();
                }
            }
        }
    }
}
