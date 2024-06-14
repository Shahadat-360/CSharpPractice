using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewUsedMethod
{
    internal class SecondClass:Person
    {
        public new void print()
        {
            Console.WriteLine("Hello world! second class");
        }
    }
}
