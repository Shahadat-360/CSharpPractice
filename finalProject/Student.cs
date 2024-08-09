using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    public class Student:User
    {
        public int StudentId {  get; set; }
        List<EnrolledCourse> EnrolledCourses { get; set; }
    }
}
