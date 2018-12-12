using DbRepository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.GuitarTab;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DbRepository.Repositories
{
    class CourseRepository : BaseRepository, ICourseRepository
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
    }
}
