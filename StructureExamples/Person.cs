using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureExamples
{
    internal struct Person : Interface1
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public void print()
        {
            Console.WriteLine($"ID:{Id} and Name: {Name}");
        }
        public Person() { 
            Id = 0;
        }
        public void info()
        {
            Console.WriteLine("I am from interface");
        }
    }
}
