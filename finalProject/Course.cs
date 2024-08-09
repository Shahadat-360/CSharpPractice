using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    public class Course
    {
        public int CourseId {  get; set; }
        public string Name { get; set; }
        public double Fees { get; set; }
        public List<CourseSchedule> CourseSchedules { get; set; }
    }
}
