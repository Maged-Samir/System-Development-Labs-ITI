using ITI.Revision.EntityFramework.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Revision.EntityFramework.Context
{
    internal class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=SchoolDB;Trusted_Connection=True;Encrypt=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>().HasKey(sc => new {sc.StudentId, sc.CourseId});
        }

        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Course> courses { get; set; }

        public DbSet<StudentCourse> StudentCourses { get; set; }


    }
}
