using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    public class Attendance
    {
        public int StudentId {  get; set; }
        public int CourseId {  get; set; }
        public int Name {  get; set; }
        public bool IsPresent {  get; set; }
        public DateOnly Date { get; set; }
    }
}
