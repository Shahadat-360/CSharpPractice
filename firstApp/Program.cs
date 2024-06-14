using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstApp
{
    internal class Program
    {
        static void Main(string[] args){
            Person person1 = new Person();
            person1.firstName = "MD. Shahadat";
            person1.middleName = "Hossain";
            person1.lastName = "Bhuian";

            string fullName=person1.GetFullName();
            Console.WriteLine(fullName);
            Console.ReadKey();
        }
    }
}
