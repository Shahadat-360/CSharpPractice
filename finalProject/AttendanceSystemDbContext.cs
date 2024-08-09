using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    public class AttendanceSystemDbContext : DbContext
    {
        private readonly string _connectionString;

        public AttendanceSystemDbContext()
        {
            _connectionString = "Server=SHAHADAT-PC\\SQLEXPRESS;Database=CSharpB17;User Id=CSharpB17;Password=123456;Trust Server Certificate=True";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(_connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EnrolledCourse>().HasKey(x => new {x.StudentId,x.CourseId});
            modelBuilder.Entity<TeacherCourse>().HasKey(x=>new {x.Teacher_Id,x.Course_Id});
            modelBuilder.Entity<Attendance>().HasKey(x => new {x.StudentId,x.CourseId});
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<EnrolledCourse> EnrolledCourses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Attendance>Attendances { get; set; }
    }
}
