using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Model.UserModel;
using Model.GuitarTab;

namespace DbRepository 
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Tab> Tabs { get; set; }

        public DbSet<Course> Courses { get; set; }
    }
}
