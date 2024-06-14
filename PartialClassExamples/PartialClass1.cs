using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassExamples
{
    internal partial class Person
    {
        public void print()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Roll);
        }
    }
}
