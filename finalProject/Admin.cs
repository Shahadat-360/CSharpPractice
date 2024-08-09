using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    public class Admin:User
    {
        public int Id {  get; set; }
        public List<Teacher> teachers {  get; set; }
        public List<Student> students { get; set; }
        public List<Course>Courses { get; set; }
        public List<EnrolledCourse> EnrolledCourses { get;set; }
        public List<CourseSchedule> CourseSchedules { get;set; }

    }
}
