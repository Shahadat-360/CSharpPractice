using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExamples
{
    internal class Person
    {
        public static int Counter { get; set; }
        public static string Name { get; set; }
        static Person() { 
            Counter = 0;
        }
        public Person()
        {
            Counter++;
        }
        public static void PrintCounter()
        {
            Console.WriteLine(Counter);
        }
    }
}
