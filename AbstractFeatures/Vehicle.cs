using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFeatures
{
    public abstract class Vehicle
    {
        public Vehicle() {
            Console.WriteLine("I am vehicle");
        }
        public abstract void startEngine();
    }
}
