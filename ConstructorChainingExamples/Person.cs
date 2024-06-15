using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChainingExamples
{
    internal class Person
    {
        string? First_Name {  get; set; }
        string? Last_Name {  get; set; }
        int? Age { get; set; }
        string? Language {  get; set; }

        public Person():this(null,null) { }
        public Person(string? first_name,string? last_name):this(first_name,last_name,null,null){}
        public Person(string? first_name,string? last_name,int? age,string? language) { 
            First_Name=first_name;
            Last_Name=last_name;
            Age = age;
            Language=language;
        }
        public void Print()
        {
            Console.WriteLine(First_Name);
            Console.WriteLine(Last_Name);
            Console.WriteLine(Age);
            Console.WriteLine(Language);
        }
    }
}
