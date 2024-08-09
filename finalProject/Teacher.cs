using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    public class Teacher:User
    {
        public int TeacherId {  get; set; }
        public List<TeacherCourse> TeacherCourses {  get; set; }
    }
}
