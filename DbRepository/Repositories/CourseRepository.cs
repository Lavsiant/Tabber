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
                var ss = context.Courses.Include(x => x.Lessons).ThenInclude(x=>x.Tab).FirstOrDefault(x => x.ID == id);
                return ss;
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

        public async Task CreateCourse(CourseCreateViewModel course)
        {
            using (var context = ContextFactory.CreateDbContext(ConnectionString))
            {
                var lessons = new List<Lesson>();
                foreach (var l in course.Lessons)
                {
                    var lesson = new Lesson();
                    lesson.Name = l.Name;
                    lesson.Tab = context.Tabs.FirstOrDefault(x => x.ID == l.tab);
                    lesson.MinTempoStep = l.stepBpm;
                    lesson.RepeatNumber = l.repeat;
                    lesson.StartBpm = l.startBpm;
                    lessons.Add(lesson);
                }
                var newCourse = new Course()
                {
                    Description = course.Description,
                    Lessons = lessons,
                    Name = course.Name,
                    Type = course.Type,
                    Creator = course.UserName
                    
                };
                context.Courses.Add(newCourse);
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

        public async Task AddCourseToUser(int id, string username)
        {
            using (var context = ContextFactory.CreateDbContext(ConnectionString))
            {
                var user = await context.Users.Include(x=>x.Courses).FirstOrDefaultAsync(x => x.UserName == username);
                var course = await context.Courses.FirstOrDefaultAsync(x => x.ID == id);
                if(user.Courses.FirstOrDefault(x=>x.ID == id) == null)
                {
                    user.Courses.Add(course);
                }
                await context.SaveChangesAsync();
            }
        }
    }
}
