using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples
{
    public class Teacher:Student
    {
        public new void talk()
        {
            Console.WriteLine("I am a Teacher");
        }
    }
}
