using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    public class CourseSchedule
    {
        public int Id {  get; set; }
        public TimeOnly StartingTime { get; set; }
        public TimeOnly EndingTime { get; set; }
        public string Day {  get; set; }
    }
}
